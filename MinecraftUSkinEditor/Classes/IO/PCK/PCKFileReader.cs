﻿using PckStudio.Classes.FileTypes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;

namespace PckStudio.Classes.IO
{
    internal class PCKFileReader
    {
        internal bool isLittleEndian = false;
        internal PCKFile _file;

        public static PCKFile Read(Stream s, bool isLittleEndian)
        {
            return new PCKFileReader(isLittleEndian).ReadFileFromStream(s);
        }

        private PCKFileReader(bool isLittleEndian)
        {
            this.isLittleEndian = isLittleEndian;
        }

        private PCKFile ReadFileFromStream(Stream s)
        {
            _file = new PCKFile(ReadInt(s));
            ReadMetaData(s);
            ReadFileEntries(s);
            return _file;
        }

        internal void ReadMetaData(Stream stream)
        {
            int meta_entry_count = ReadInt(stream);
            bool has_xml_tag = false;
            _file.meta_data.Capacity = meta_entry_count;
            for (; 0 < meta_entry_count; meta_entry_count--)
            {
                int index = ReadInt(stream);
                string value = ReadString(stream);
                if (value.Equals("XMLVERSION")) has_xml_tag = true;
                _file.meta_data.Insert(index, value);
            }
            if (has_xml_tag)
                Console.WriteLine(ReadInt(stream)); // xml version num ??
        }

        internal void ReadFileEntries(Stream stream)
        {
            int file_entry_count = ReadInt(stream);
            for (; 0 < file_entry_count; file_entry_count--)
            {
                int file_size = ReadInt(stream);
                int file_type = ReadInt(stream);
                string name = ReadString(stream);
                var entry = new PCKFile.FileData(name, file_type, file_size);
                _file.file_entries.Add(entry);
            }
            foreach (var file_entry in _file.file_entries)
            {
                int property_count = ReadInt(stream);
                for (; 0 < property_count; property_count--)
                {
                    int index = ReadInt(stream);
                    string key = _file.meta_data[index];
                    string value = ReadString(stream);
                    file_entry.properties.Add(new ValueTuple<string, string>(key, value));
                }
                // file data buffer is only allocated when FileData is constructed with `dataSize`
                stream.Read(file_entry.data, 0, file_entry.size);
            }
        }

        internal int ReadInt(Stream stream)
        {
            byte[] buffer = new byte[4];
            stream.Read(buffer, 0, 4);
            if (BitConverter.IsLittleEndian && !isLittleEndian)
                Array.Reverse(buffer);
            return BitConverter.ToInt32(buffer, 0);
        }

        internal string ReadString(Stream stream)
        {
            int len = ReadInt(stream);
            byte[] stringBuffer = new byte[len * 2];
            stream.Read(stringBuffer, 0, len * 2);
            ReadInt(stream);
            return Encoding.BigEndianUnicode.GetString(stringBuffer, 0, len * 2);
        }
    }
}
