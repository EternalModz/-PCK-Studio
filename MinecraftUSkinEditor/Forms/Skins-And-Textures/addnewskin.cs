﻿using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using PckStudio.Classes.FileTypes;
using System.Drawing.Imaging;

namespace PckStudio
{
    public partial class addNewSkin : MetroFramework.Forms.MetroForm
    {
        LOCFile currentLoc;
        PCKFile.FileData skin = new PCKFile.FileData("dlcskin", 0);
        PCKFile.FileData cape = new PCKFile.FileData("dlccape", 1);

        public PCKFile.FileData Skin => skin;
        public PCKFile.FileData Cape => cape;

        eSkinType skinType;
        public bool useCape = false;
        string localID = "0";
        PCKProperties generatedModel = new PCKProperties();

        enum eSkinType : int
        {
            Invalid = -1,
            _64x64,
            _64x32,
            _64x64HD,
            _64x32HD,
            Custom,
        }

        public addNewSkin(LOCFile loc)
        {
            InitializeComponent();
            currentLoc = loc;
        }

        private void checkImage(Image img)
        {
            //Checks image dimensions and sets things accordingly
            switch (img.Height) // 64x64
            {
                case 64:
                    MessageBox.Show("64x64 Skin Detected");
                    skinPictureBoxTexture.Width = skinPictureBoxTexture.Height;
                    if (skinType != eSkinType._64x64 && skinType != eSkinType._64x64HD)
                    {
                        buttonSkin.Location = new Point(buttonSkin.Location.X - skinPictureBoxTexture.Width, buttonSkin.Location.Y);
                    }
                    comboBoxSkinType.Text = "Steve (64x64)";
                    skinType = eSkinType._64x64;
                    break;
                case 32:
                    MessageBox.Show("64x32 Skin Detected");
                    skinPictureBoxTexture.Width = skinPictureBoxTexture.Height * 2;
                    if (skinType == eSkinType._64x64)
                    {
                        buttonSkin.Location = new Point(buttonSkin.Location.X + skinPictureBoxTexture.Width / 2, buttonSkin.Location.Y);
                    }
                    if (skinType == eSkinType._64x64HD)
                    {
                        buttonSkin.Location = new Point(buttonSkin.Location.X + skinPictureBoxTexture.Width / 2, buttonSkin.Location.Y);
                    }
                    comboBoxSkinType.Text = "Default (64x32)";
                    skinType = eSkinType._64x32;
                    break;
                default:
                    if (img.Width == img.Height) // 64x64 HD
                    {
                        MessageBox.Show("64x64 HD Skin Detected");
                        skinPictureBoxTexture.Width = skinPictureBoxTexture.Height;
                        if (skinType != eSkinType._64x64 && skinType != eSkinType._64x64HD)
                        {
                            buttonSkin.Location = new Point(buttonSkin.Location.X - skinPictureBoxTexture.Width, buttonSkin.Location.Y);
                        }
                        comboBoxSkinType.Text = "Steve (64x64)";
                        skinType = eSkinType._64x64HD;
                    }
                    else if (img.Width == img.Height / 2) // 64x32 HD
                    {
                        MessageBox.Show("64x32 HD Skin Detected");
                        skinPictureBoxTexture.Width = skinPictureBoxTexture.Height * 2;
                        if (skinType == eSkinType._64x64)
                        {
                            buttonSkin.Location = new Point(buttonSkin.Location.X + skinPictureBoxTexture.Width / 2, buttonSkin.Location.Y);
                        }
                        if (skinType == eSkinType._64x64HD)
                        {
                            buttonSkin.Location = new Point(buttonSkin.Location.X + skinPictureBoxTexture.Width / 2, buttonSkin.Location.Y);
                        }
                        comboBoxSkinType.Text = "Default (64x32)";
                        skinType = eSkinType._64x32HD;
                    }
                    else //If dimensions don't fit any skin type //Invalid
                    {
                        MessageBox.Show("Not a Valid Skin File");
                        skinType = eSkinType.Invalid;
                        return;
                    }
                    break;
            }
            comboBoxSkinType.Enabled = skinType == eSkinType._64x64 || skinType == eSkinType._64x64HD;
            if (comboBoxSkinType.Items.Count == 3)
            {
                comboBoxSkinType.Items.RemoveAt(0);
            }

            skinPictureBoxTexture.SizeMode = PictureBoxSizeMode.StretchImage;
            skinPictureBoxTexture.InterpolationMode = InterpolationMode.NearestNeighbor;
            skinPictureBoxTexture.Image = img;

            buttonDone.Enabled = true;
            labelSelectTexture.Visible = false;

            //skin.SetData();
        }

        private void addnewskin_Load(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(displayBox.Width, displayBox.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                //Head
                g.DrawRectangle(Pens.Black, 70, 15, 40, 40);
                g.FillRectangle(Brushes.Gray, 71, 16, 39, 39);
                //Body
                g.DrawRectangle(Pens.Black, 70, 55, 40, 60);
                g.FillRectangle(Brushes.Gray, 71, 56, 39, 59);
                //Arm0
                g.DrawRectangle(Pens.Black, 50, 55, 20, 60);
                g.FillRectangle(Brushes.Gray, 51, 56, 19, 59);
                //Arm1
                g.DrawRectangle(Pens.Black, 110, 55, 20, 60);
                g.FillRectangle(Brushes.Gray, 111, 56, 19, 59);
                //Leg0
                g.DrawRectangle(Pens.Black, 70, 115, 20, 60);
                g.FillRectangle(Brushes.Gray, 71, 116, 19, 59);
                //Leg1
                g.DrawRectangle(Pens.Black, 90, 115, 20, 60);
                g.FillRectangle(Brushes.Gray, 91, 116, 19, 59);
            }
            displayBox.Image = bmp;
        }

        private void buttonSkin_Click(object sender, EventArgs e)
        {
            contextMenuSkin.Show(ActiveForm.Location.X + buttonSkin.Location.X + 2, ActiveForm.Location.Y + buttonSkin.Location.Y + 23);
        }

        private void buttonCape_Click(object sender, EventArgs e)
        {
            contextMenuCape.Show(ActiveForm.Location.X + buttonCape.Location.X + 2, ActiveForm.Location.Y + buttonCape.Location.Y + 23);
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                checkImage(Image.FromFile(ofd.FileName));
            }
        }

        private void replaceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (var ofd1 = new OpenFileDialog())
            {
                ofd1.Filter = "PNG Files | *.png";
                ofd1.Title = "Select a PNG File";
                if (ofd1.ShowDialog() == DialogResult.OK)
                {
                    var img = Image.FromFile(ofd1.FileName);
                    if (img.Width == img.Height * 2)
                    {
                        useCape = true;
                        capePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        capePictureBox.InterpolationMode = InterpolationMode.NearestNeighbor;
                        capePictureBox.Image = Image.FromFile(ofd1.FileName);
                        cape.SetData(File.ReadAllBytes(ofd1.FileName));
                        contextMenuCape.Items[0].Text = "Replace";
                    }
                    else
                    {
                        MessageBox.Show("Not a Valid Cape File");
                    }
                }
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            int _skinId = -1;
            if (!int.TryParse(textSkinID.Text, out _skinId))
                MessageBox.Show("The Skin ID Must be a Unique 8 Digit Number Thats Not Already in Use", "Invalid Skin ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            string skinId = _skinId.ToString("d08");
            if (useCape)
            {
                try
                {
                    cape.name = $"dlccape{skinId}.png";
                    skin.properties.Add(new ValueTuple<string, string>("CAPEPATH", cape.name));
                }
                catch (Exception)
                {
                    MessageBox.Show("Cape Could Not be Added");
                }
            }
            string skinDisplayNameLocKey = $"IDS_dlcskin{skinId}_DISPLAYNAME";
            currentLoc.AddLocKey(skinDisplayNameLocKey, textSkinName.Text);
            skin.properties.Add(new ValueTuple<string, string>("DISPLAYNAME", textSkinName.Text));
            skin.properties.Add(new ValueTuple<string, string>("DISPLAYNAMEID", skinDisplayNameLocKey));
            using (var stream = new MemoryStream())
            {
                skinPictureBoxTexture.Image.Save(stream, ImageFormat.Png);
                skin.SetData(stream.ToArray());
            }
            if (comboBoxSkinType.Text == "Alex (64x64)" && skinType != eSkinType._64x32)
            {
                skin.properties.Add(new ValueTuple<string, string>("ANIM", "0x80000"));
            }
            else if (comboBoxSkinType.Text == "Steve (64x64)" && skinType != eSkinType._64x32)
            {
                skin.properties.Add(new ValueTuple<string, string>("ANIM", "0x40000"));
            }
            else if (comboBoxSkinType.Text == "Custom")
            {
                //skin.properties.Add(new ValueTuple<string, string>( "BOX", listViewItem.Tag.ToString() + " " + listViewItem.SubItems[1].Text + " " + listViewItem.SubItems[2].Text + " " + listViewItem.SubItems[3].Text + " " + listViewItem.SubItems[4].Text + " " + listViewItem.SubItems[5].Text + " " + listViewItem.SubItems[6].Text + " " + listViewItem.SubItems[7].Text + " " + listViewItem.SubItems[8].Text)) }.Tag ));
                skin.properties.Add(new ValueTuple<string, string>("ANIM", "0x7ff5fc10"));
                foreach (var item in generatedModel)
                {
                    skin.properties.Add(item);
                }
            }
            if (generatedModel != null)
            {
                generatedModel.Clear();
            }

            if (!string.IsNullOrEmpty(textThemeName.Text))
            {
                skin.properties.Add(new ValueTuple<string, string>("THEMENAME", textThemeName.Text));
                currentLoc.AddLocKey($"IDS_dlcskin{skinId}_THEMENAME", textThemeName.Text);
            }

            skin.properties.Add(new ValueTuple<string, string>("GAME_FLAGS", "0x18"));
            skin.properties.Add(new ValueTuple<string, string>("FREE", "1"));
            skin.name = "dlcskin" + skinId + ".png";
            DialogResult = DialogResult.OK;
            Close();
        }

        private void textSkinID_TextChanged_1(object sender, EventArgs e)
        {
            bool validSkinId = int.TryParse(textSkinID.Text, out _);
            textSkinID.ForeColor = validSkinId ? Color.Green : Color.Red;
            if (radioLOCAL.Checked && validSkinId)
                localID = textSkinID.Text;
        }

        private void CreateCustomModel_Click(object sender, EventArgs e)
        {
            //Prompt for skin model generator
            if (MessageBox.Show("Create your own custom skin model?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) != DialogResult.Yes)
                return;
            
            PictureBox preview = new PictureBox(); //Creates new picture for generated model preview
            generateModel generate = new generateModel(generatedModel, preview);

            if (generate.ShowDialog() == DialogResult.OK) //Opens Model Generator Dialog
            {
                comboBoxSkinType.Items.Add("Custom"); //Adds skin preset to combobox
                comboBoxSkinType.Text = "Custom"; //Sets combo to custom preset
                displayBox.Image = preview.Image; //Sets displayBox to created model preview
                try
                {
                    using (FileStream stream = File.OpenRead(Application.StartupPath + "\\temp.png"))
                    {
                        skinPictureBoxTexture.SizeMode = PictureBoxSizeMode.StretchImage;
                        skinPictureBoxTexture.InterpolationMode = InterpolationMode.NearestNeighbor;
                        skinPictureBoxTexture.Image = Image.FromStream(stream);
                        stream.Close();
                        stream.Dispose();
                    }
                    skinPictureBoxTexture.Width = skinPictureBoxTexture.Height;
                    buttonDone.Enabled = true;
                    labelSelectTexture.Visible = false;
                    if (skinType != eSkinType._64x64 && skinType != eSkinType._64x64HD)
                    {
                        buttonSkin.Location = new Point(buttonSkin.Location.X - skinPictureBoxTexture.Width, buttonSkin.Location.Y);
                        skinType = eSkinType._64x64;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAUTO.Checked)
            {
                try
                {
                    Random random = new Random();
                    int num = random.Next(100000, 99999999);
                    textSkinID.Text = num.ToString();
                    textSkinID.Enabled = false;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void radioLOCAL_CheckedChanged(object sender, EventArgs e)
        {
            if (radioLOCAL.Checked)
            {
                textSkinID.Text = localID;
                textSkinID.Enabled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (var ofdd = new OpenFileDialog())
            {
                ofdd.Filter = "PNG Files | *.png";
                ofdd.Title = "Select a PNG File";
                if (ofdd.ShowDialog() == DialogResult.OK)
                {
                    checkImage(Image.FromFile(ofdd.FileName));
                }
            }
        }

        private void radioSERVER_CheckedChanged(object sender, EventArgs e)
        {

            if (radioSERVER.Checked)
            {
            }
        }
    }
}

