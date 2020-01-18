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
