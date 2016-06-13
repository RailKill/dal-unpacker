using System.Collections.Generic;

namespace dal_unpacker
{
    /// <summary>
    /// A searcher that looks for a given pattern in a byte array.
    /// </summary>
    class ByteArraySearcher
    {
        /// <summary>
        /// Dictionary containing all known byte header patterns and its file extension.
        /// </summary>
        private Dictionary<byte[], string> PatternDictionary;

        /// <summary>
        /// Default constructor which initializes all known Darkness and Light game file formats.
        /// </summary>
        public ByteArraySearcher()
        {
            PatternDictionary = new Dictionary<byte[], string>();
            PatternDictionary.Add(ByteHeaders.DDS, ".dds");
            PatternDictionary.Add(ByteHeaders.DRA, ".dra");
            PatternDictionary.Add(ByteHeaders.DRC, ".drc");
            PatternDictionary.Add(ByteHeaders.DRE, ".dre");
            PatternDictionary.Add(ByteHeaders.DRG, ".drg");
        }

        /// <summary>
        /// Locates the position of a given pattern in a target byte array.
        /// </summary>
        /// <param name="target">Target byte array.</param>
        /// <returns>An unsorted dictionary with a file extension value for each position key. 
        /// Because dictionaries have no order, you must sort the keys (positions) before manipulating it.</returns>
        public Dictionary<int, string> Locate(byte[] target)
        {
            Dictionary<int, string> positionDictionary = new Dictionary<int, string>();

            // Validate inputs before proceeding.
            foreach (byte[] pattern in PatternDictionary.Keys)
            {
                if (IsEmptyLocate(target, pattern))
                    return positionDictionary;
            }
                        
            // Start locating file positions.
            for (int i = 0; i < target.Length; i++)
            {
                foreach (byte[] pattern in PatternDictionary.Keys)
                {
                    if (!IsMatch(target, i, pattern))
                        continue;

                    positionDictionary.Add(i, PatternDictionary[pattern]);
                }
            }

            return positionDictionary;
        }

        /// <summary>
        /// Checks if there is a match in pattern.
        /// </summary>
        /// <param name="array">Target array to check.</param>
        /// <param name="position">Position in the target array.</param>
        /// <param name="pattern">Pattern to check for.</param>
        /// <returns></returns>
        private bool IsMatch(byte[] array, int position, byte[] pattern)
        {
            if (pattern.Length > (array.Length - position))
                return false;

            for (int i = 0; i < pattern.Length; i++)
                if (array[position + i] != pattern[i])
                    return false;

            return true;
        }

        /// <summary>
        /// Checks if the given target array or pattern is empty or invalid.
        /// </summary>
        /// <param name="array">Target array.</param>
        /// <param name="pattern">Pattern array.</param>
        /// <returns></returns>
        private bool IsEmptyLocate(byte[] array, byte[] pattern)
        {
            return array == null
                || pattern == null
                || array.Length == 0
                || pattern.Length == 0
                || pattern.Length > array.Length;
        }
    }
}
