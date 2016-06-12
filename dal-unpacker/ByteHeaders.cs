using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal_unpacker
{
    /// <summary>
    /// Constants containing all the byte headers for known files used in Darkness and Light game.
    /// </summary>
    public static class ByteHeaders
    {
        /// <summary>
        /// .DDS file header.
        /// </summary>
        public static byte[] DDS = Encoding.UTF8.GetBytes("DDS |");
    }
}
