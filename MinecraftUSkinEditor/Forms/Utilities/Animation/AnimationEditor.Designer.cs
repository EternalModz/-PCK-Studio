﻿namespace PckStudio
{
	partial class AnimationEditor
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimationEditor));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addFrameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeFrameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bulkAnimationSpeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importJavaAnimationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InterpolationCheckbox = new MetroFramework.Controls.MetroCheckBox();
            this.AnimationPlayBtn = new MetroFramework.Controls.MetroButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.AnimationStopBtn = new MetroFramework.Controls.MetroButton();
            this.tileLabel = new MetroFramework.Controls.MetroLabel();
            this.MipMapCheckbox = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.MipMapNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pictureBoxWithInterpolationMode1 = new PckStudio.PictureBoxWithInterpolationMode();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MipMapNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWithInterpolationMode1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
            this.treeView1.ForeColor = System.Drawing.Color.White;
            this.treeView1.Location = new System.Drawing.Point(20, 84);
            this.treeView1.Margin = new System.Windows.Forms.Padding(0);
            this.treeView1.MaximumSize = new System.Drawing.Size(205, 350);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(165, 202);
            this.treeView1.TabIndex = 15;
            this.treeView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView1_ItemDrag);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_doubleClick);
            this.treeView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView1_DragDrop);
            this.treeView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView1_DragEnter);
            this.treeView1.DragOver += new System.Windows.Forms.DragEventHandler(this.treeView1_DragOver);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFrameToolStripMenuItem,
            this.removeFrameToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 48);
            // 
            // addFrameToolStripMenuItem
            // 
            this.addFrameToolStripMenuItem.Image = global::PckStudio.Properties.Resources.ExportFile;
            this.addFrameToolStripMenuItem.Name = "addFrameToolStripMenuItem";
            this.addFrameToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.addFrameToolStripMenuItem.Text = "Add Frame";
            this.addFrameToolStripMenuItem.Click += new System.EventHandler(this.addFrameToolStripMenuItem_Click);
            // 
            // removeFrameToolStripMenuItem
            // 
            this.removeFrameToolStripMenuItem.Image = global::PckStudio.Properties.Resources.Del;
            this.removeFrameToolStripMenuItem.Name = "removeFrameToolStripMenuItem";
            this.removeFrameToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.removeFrameToolStripMenuItem.Text = "Remove Frame";
            this.removeFrameToolStripMenuItem.Click += new System.EventHandler(this.removeFrameToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.AutoSize = false;
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(20, 60);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(372, 24);
            this.menuStrip.TabIndex = 14;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem1});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem1.Image")));
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bulkAnimationSpeedToolStripMenuItem,
            this.importJavaAnimationToolStripMenuItem,
            this.changeTileToolStripMenuItem});
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.editToolStripMenuItem.Text = "Tools";
            // 
            // bulkAnimationSpeedToolStripMenuItem
            // 
            this.bulkAnimationSpeedToolStripMenuItem.Image = global::PckStudio.Properties.Resources.clock;
            this.bulkAnimationSpeedToolStripMenuItem.Name = "bulkAnimationSpeedToolStripMenuItem";
            this.bulkAnimationSpeedToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.bulkAnimationSpeedToolStripMenuItem.Text = "Set Bulk Animation Speed";
            this.bulkAnimationSpeedToolStripMenuItem.Click += new System.EventHandler(this.bulkAnimationSpeedToolStripMenuItem_Click);
            // 
            // importJavaAnimationToolStripMenuItem
            // 
            this.importJavaAnimationToolStripMenuItem.Image = global::PckStudio.Properties.Resources.ExportFile;
            this.importJavaAnimationToolStripMenuItem.Name = "importJavaAnimationToolStripMenuItem";
            this.importJavaAnimationToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.importJavaAnimationToolStripMenuItem.Text = "Import Java Animation";
            this.importJavaAnimationToolStripMenuItem.Click += new System.EventHandler(this.importJavaAnimationToolStripMenuItem_Click);
            // 
            // changeTileToolStripMenuItem
            // 
            this.changeTileToolStripMenuItem.Image = global::PckStudio.Properties.Resources.changeTile;
            this.changeTileToolStripMenuItem.Name = "changeTileToolStripMenuItem";
            this.changeTileToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.changeTileToolStripMenuItem.Text = "Change Tile";
            this.changeTileToolStripMenuItem.Click += new System.EventHandler(this.changeTileToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // InterpolationCheckbox
            // 
            this.InterpolationCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InterpolationCheckbox.AutoSize = true;
            this.InterpolationCheckbox.Location = new System.Drawing.Point(188, 317);
            this.InterpolationCheckbox.Name = "InterpolationCheckbox";
            this.InterpolationCheckbox.Size = new System.Drawing.Size(204, 15);
            this.InterpolationCheckbox.TabIndex = 17;
            this.InterpolationCheckbox.Text = "Interpolates (not simulated above)";
            this.InterpolationCheckbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.InterpolationCheckbox.UseSelectable = true;
            // 
            // AnimationPlayBtn
            // 
            this.AnimationPlayBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AnimationPlayBtn.Location = new System.Drawing.Point(188, 291);
            this.AnimationPlayBtn.Name = "AnimationPlayBtn";
            this.AnimationPlayBtn.Size = new System.Drawing.Size(99, 24);
            this.AnimationPlayBtn.TabIndex = 18;
            this.AnimationPlayBtn.Text = "Play Animation";
            this.AnimationPlayBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AnimationPlayBtn.UseSelectable = true;
            this.AnimationPlayBtn.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.animate);
            // 
            // AnimationStopBtn
            // 
            this.AnimationStopBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AnimationStopBtn.Enabled = false;
            this.AnimationStopBtn.Location = new System.Drawing.Point(293, 291);
            this.AnimationStopBtn.Name = "AnimationStopBtn";
            this.AnimationStopBtn.Size = new System.Drawing.Size(99, 24);
            this.AnimationStopBtn.TabIndex = 19;
            this.AnimationStopBtn.Text = "Stop Animation";
            this.AnimationStopBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AnimationStopBtn.UseSelectable = true;
            this.AnimationStopBtn.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // tileLabel
            // 
            this.tileLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tileLabel.AutoSize = true;
            this.tileLabel.Location = new System.Drawing.Point(20, 290);
            this.tileLabel.MinimumSize = new System.Drawing.Size(170, 19);
            this.tileLabel.Name = "tileLabel";
            this.tileLabel.Size = new System.Drawing.Size(57, 19);
            this.tileLabel.TabIndex = 20;
            this.tileLabel.Text = "tileLabel";
            this.tileLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // MipMapCheckbox
            // 
            this.MipMapCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MipMapCheckbox.AutoSize = true;
            this.MipMapCheckbox.Location = new System.Drawing.Point(20, 312);
            this.MipMapCheckbox.Name = "MipMapCheckbox";
            this.MipMapCheckbox.Size = new System.Drawing.Size(128, 15);
            this.MipMapCheckbox.TabIndex = 21;
            this.MipMapCheckbox.Text = "Is Mip Map Texture?";
            this.MipMapCheckbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MipMapCheckbox.UseSelectable = true;
            this.MipMapCheckbox.CheckedChanged += new System.EventHandler(this.metroCheckBox2_CheckedChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(21, 330);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(99, 19);
            this.metroLabel1.TabIndex = 22;
            this.metroLabel1.Text = "Mip Map Level:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.Visible = false;
            // 
            // MipMapNumericUpDown
            // 
            this.MipMapNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MipMapNumericUpDown.BackColor = System.Drawing.Color.Black;
            this.MipMapNumericUpDown.ForeColor = System.Drawing.SystemColors.Window;
            this.MipMapNumericUpDown.Location = new System.Drawing.Point(127, 330);
            this.MipMapNumericUpDown.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.MipMapNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.MipMapNumericUpDown.Name = "MipMapNumericUpDown";
            this.MipMapNumericUpDown.Size = new System.Drawing.Size(44, 20);
            this.MipMapNumericUpDown.TabIndex = 23;
            this.MipMapNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.MipMapNumericUpDown.Visible = false;
            // 
            // pictureBoxWithInterpolationMode1
            // 
            this.pictureBoxWithInterpolationMode1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxWithInterpolationMode1.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            this.pictureBoxWithInterpolationMode1.Location = new System.Drawing.Point(188, 88);
            this.pictureBoxWithInterpolationMode1.Name = "pictureBoxWithInterpolationMode1";
            this.pictureBoxWithInterpolationMode1.Size = new System.Drawing.Size(204, 198);
            this.pictureBoxWithInterpolationMode1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxWithInterpolationMode1.TabIndex = 16;
            this.pictureBoxWithInterpolationMode1.TabStop = false;
            // 
            // AnimationEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 362);
            this.Controls.Add(this.AnimationStopBtn);
            this.Controls.Add(this.AnimationPlayBtn);
            this.Controls.Add(this.MipMapNumericUpDown);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.MipMapCheckbox);
            this.Controls.Add(this.tileLabel);
            this.Controls.Add(this.InterpolationCheckbox);
            this.Controls.Add(this.pictureBoxWithInterpolationMode1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnimationEditor";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Animation Editor";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MipMapNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWithInterpolationMode1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
		private PictureBoxWithInterpolationMode pictureBoxWithInterpolationMode1;
		private MetroFramework.Controls.MetroCheckBox InterpolationCheckbox;
		private MetroFramework.Controls.MetroButton AnimationPlayBtn;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem addFrameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem removeFrameToolStripMenuItem;
		private System.Windows.Forms.Timer timer1;
		private MetroFramework.Controls.MetroButton AnimationStopBtn;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bulkAnimationSpeedToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem importJavaAnimationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem changeTileToolStripMenuItem;
		private MetroFramework.Controls.MetroLabel tileLabel;
		private MetroFramework.Controls.MetroCheckBox MipMapCheckbox;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private System.Windows.Forms.NumericUpDown MipMapNumericUpDown;
	}
}