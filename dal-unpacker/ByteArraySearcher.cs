using System.Collections.Generic;

namespace dal_unpacker
{
    /// <summary>
    /// A searcher that looks for a given pattern in a byte array.
    /// </summary>
    class ByteArraySearcher
    {
        /// <summary>
        /// Empty integer array.
        /// </summary>
        int[] Empty = new int[0];

        /// <summary>
        /// Locates the position of a given pattern in a target byte array.
        /// </summary>
        /// <param name="target">Target byte array.</param>
        /// <param name="pattern">Pattern to be searched.</param>
        /// <returns>Integer array of positions.</returns>
        public int[] Locate(byte[] target, byte[] pattern)
        {
            if (IsEmptyLocate(target, pattern))
                return Empty;

            var list = new List<int>();

            for (int i = 0; i < target.Length; i++)
            {
                if (!IsMatch(target, i, pattern))
                    continue;

                list.Add(i);
            }

            return list.Count == 0 ? Empty : list.ToArray();
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
