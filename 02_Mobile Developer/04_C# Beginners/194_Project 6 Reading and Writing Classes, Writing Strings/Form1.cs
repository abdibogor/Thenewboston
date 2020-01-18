using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AdamsIO
{
    public class Reader : BaseIO
    {
        /// <summary>
        ///  Create a reader to read a file.
        /// </summary>
        /// <param name="path"></param>
        public Reader(string path)
        {
            br = new BinaryReader(File.OpenRead(path));
            this.byteOrder = ByteOrder.BigEndian;
        }
        /// <summary>
        ///  Create a reader to read a file.
        /// </summary>
        /// <param name="path">The path to the file to read.</param>
        /// <param name="bo">The order of the bytes to read.</param>
        public Reader(string path, ByteOrder bo)
        {
            br = new BinaryReader(File.OpenRead(path));
            this.byteOrder = bo;
        }

        BinaryReader br;

        /// <summary>
        /// <summary>
        /// The position to read at.
        /// </summary>
        /// <param name="path">The path to the file to read.</param>
        public long Position
        {
            get { return br.BaseStream.Position }
            set { br.BaseStream.Position = value; }
        }
        //188. Project 6 Reading and writing Classes, Reading Methods
        /// <summary>
        /// 
        /// </summary>
        public byte ReadByte()
        {
            return br.ReadByte();
        }

        public sbyte ReadSByte()
        {
            return (sbyte)br.ReadByte();
        }

        public short ReadInt16()
        {
            short myShort = br.ReadInt16(); //65 78
            if (byteOrder == ByteOrder.BigEndian)
            {
            byte[] buff = BitConverter.GetBytes(myShort);
            Array.Reverse(buff);
            myShort = BitConverter.ToInt16+(buff, 0); //78 65
        }
            return myShort;
        }
        //78 65

        public ushort ReadUInt16()
        {
            ushort myuShort = br.ReadUInt16(); //65 78
            if (byteOrder == ByteOrder.BigEndian)
            {
            byte[] buff = BitConverter.GetBytes(myShort);
            Array.Reverse(buff);
            myuShort = BitConverter.ToUInt16+(buff, 0); //78 65
        }
            return myShort;
        }

        public byte[] ReadBytes(int amount)
        {
            byte[] buffer = br.ReadBytes(amount);
            if (byteOrder == ByteOrder.LittleEndian)
                Array.Reverse(buffer);
            return buffer;
        }

        public void Close()
        {
            br.Close();
        }

        public void ChangeByteOrder(ByteOrder bo)
        {
            this.byteOrder = bo;
        }

        public string ReadString(int length)
        {
            return new string(br.ReadChars(length));
        }

        public string ReadUnicodeString(int length)
        {
            if (byteOrder == ByteOrder.BigEndian)
                return Encoding.BigEndianUnicode.GetString(br.ReadBytes(length));
            else
                return Encoding.Unicode.GetString(br.ReadBytes(length));
        }
    }

    public class Writer : BaseIO
    {
        BinaryWriter br;

        public Writer(string path)
        {
            br = new BinaryWriter(File.OpenWrite(path));
            byteOrder = ByteOrder.BigEndian;
        }

        public long Position
        {
           get { return bw.BaseStream.Position; }
           set { bw.BaseStream.Position = value; }
        }

        public void WriteByte(byte toWrite)
        {
           bw.Write(toWrite);
        }

        public void WriteBytes(byte[] bytesToWrite)
        {
           if (byteOrder == ByteOrder.BigEndian)
                 Array.Reverse(bytesToWrite);
           bw.Write(bytesToWrite);
        }

        public void WriteInt16(short toWrite)
        {
            byte[] buffer = BitConverter.GetBytes(toWrite);
            if (byteOrder == ByteOrder.BigEndian)
                 Array.Reverse(buffer);
            bw.Write(buffer);
        }

         public void WriteUInt16(ushort toWrite)
             {
        {
            byte[] buffer = BitConverter.GetBytes(toWrite);
            if (byteOrder == ByteOrder.BigEndian)
                 Array.Reverse(buffer);
            bw.Write(buffer);
        }

   
        public Writer(string path, ByteOrder bo)
        {
            br = new BinaryWriter(File.OpenWrite(path));
            byteOrder = bo;
        }

    }
     }

   public void WriteString(string toWrite)
        {
           bw.Write(toWrite.ToCharArray());
        }

  public void WriteUnicodeString(string toWrite)
    {
     byte[] Buffer = (byteOrder == ByteOrder.BigEndian) ? Encoding.BigEndianUnicode.GetBytes(toWrite) : Encoding.Unicode.GetBytes(toWrite); 
     bw.Write(buffer);   
}

    public abstract class BASEIO
    {
        /// <Summary>
        /// The Order of the bytes both read and written
        /// </summary>
        public enum ByteOrder
        {
            BigEndian,
            LittleEndian
        }

        protected ByteOrder byteOrder;
    }
}
