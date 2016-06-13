using System.Text;

namespace dal_unpacker
{
    /// <summary>
    /// Constants containing all the byte headers for known files used in Darkness and Light game.
    /// </summary>
    public static class ByteHeaders
    {
        /// <summary>
        /// Texture .DDS file header.
        /// This is the file pattern used for 2D textures.
        /// </summary>
        public static byte[] DDS = Encoding.UTF8.GetBytes("DDS |");

        /// <summary>
        /// Particle Effects .DRE file header.
        /// This is the file pattern that is most associated with particle effects such as blood hit, light, etc.
        /// </summary>
        public static byte[] DRE = new byte[]
        {
            123, 20, 142, 63, 0, 0, 160, 192, 0, 0, 160, 192, 0, 0, 160, 192,
            0, 0, 160, 64, 0, 0, 160, 64, 0, 0, 160, 64, 0, 0, 160, 64,
            0, 0, 0, 0
        };

        /// <summary>
        /// Animation .DRA file header.
        /// This is the file pattern that is most like a script with some sequence of animation names, sounds and models.
        /// </summary>
        public static byte[] DRA = new byte[]
        {
            205, 204, 140, 63
        };

        /// <summary>
        /// 3D Model .DRG file header.
        /// This is the file pattern that is most associated with 3D model like bones and human body part names.
        /// </summary>
        public static byte[] DRG = new byte[]
        {
            51, 51, 147, 63
        };

        /// <summary>
        /// Potential 2D Element or 3D Model .DRC file header.
        /// This is the file pattern that may either be a 2D element or an unrigged 3D model.
        /// </summary>
        public static byte[] DRC = new byte[]
        {
            10, 215, 163, 63, 1, 0, 0, 0
        };

        /// <summary>
        /// OGG Vorbis .OGG file header for sound files.
        /// </summary>
        public static byte[] OGG = new byte[]
        {
            79, 103, 103, 83, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0
        };
    }
}
