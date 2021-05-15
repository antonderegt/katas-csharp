using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas.LargestDifference
{
    /// <summary>
    /// Calculates the largest difference between numbers in an array and the number of consecutive pairs that sum up to that value.
    /// </summary>
    public class LargestDifference
    {
        public int[] Numbers { get; set; }
        public int Min { get; set; } = int.MaxValue;
        public int Max { get; set; } = int.MinValue;
        public int Diff { get; set; } = 0;
        public int Pairs { get; set; } = 0;

        /// <summary>
        /// Initializes the class.
        /// </summary>
        /// <param name="nums">Input array of integers</param>
        public LargestDifference(int[] nums)
        {
            Numbers = nums;
        }

        /// <summary>
        /// Calculates the largest difference between numbers in the array.
        /// </summary>
        /// <returns>int of the largest difference</returns>
        public int LargestDiff()
        {
            foreach (var num in Numbers)
            {
                Min = num < Min ? num : Min;
                Max = num > Max ? num : Max;
            }

            Diff = Max - Min;

            return Diff;
        }

        /// <summary>
        /// Calculates number of pairs that sum up to the largest difference
        /// </summary>
        /// <returns>int of number of pairs</returns>
        /// <exception cref="ArgumentException">When largest difference is below 0</exception>
        public int NumberOfPairs()
        {
            if (Diff < 0)
                throw new ArgumentException("Can't calculate pairs when difference is negative.");

            for (int i = 0; i < Numbers.Length; i++)
            {
                int currentValue = Numbers[i];
                int neededForPair = Diff - currentValue;
                IEnumerable<int> slice = Numbers.Skip(i + 1);

                if (slice.Contains(neededForPair)) Pairs++;
            }

            return Pairs;
        }
    }
}
