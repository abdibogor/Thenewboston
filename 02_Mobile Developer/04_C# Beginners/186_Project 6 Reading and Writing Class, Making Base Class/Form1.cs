using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdamsIO
{
   public abstract class BASEIO
    {
        // <Summary>
        // The Order of the bytes both read and written
        // </summary>
       public enum ByteOrder
       { 
           BigEndian,
           LittleEndian
       }

       protected ByteOrder byteOrder;
    }
}
