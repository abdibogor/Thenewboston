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
