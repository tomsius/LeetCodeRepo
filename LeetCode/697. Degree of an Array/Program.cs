using System;
using System.Collections.Generic;

namespace _697._Degree_of_an_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 2, 3, 1 };
            Console.WriteLine(FindShortestSubArray1(nums1));
            Console.WriteLine(FindShortestSubArray2(nums1));

            int[] nums2 = { 1, 2, 2, 3, 1, 4, 2 };
            Console.WriteLine(FindShortestSubArray1(nums2));
            Console.WriteLine(FindShortestSubArray2(nums2));

            int[] nums3 = { 1 };
            Console.WriteLine(FindShortestSubArray1(nums3));
            Console.WriteLine(FindShortestSubArray2(nums3));
        }

        public static int FindShortestSubArray1(int[] nums)
        {
            int[] startIndices = new int[50000];
            int[] endIndices = new int[50000];
            int[] counts = new int[50000];
            int maxCount = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                counts[nums[i]]++;
                maxCount = Math.Max(maxCount, counts[nums[i]]);

                if (startIndices[nums[i]] == 0)
                {
                    startIndices[nums[i]] = i + 1;
                }

                endIndices[nums[i]] = i + 1;

            }

            int smallestSubarraySize = int.MaxValue;

            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] == maxCount)
                {
                    smallestSubarraySize = Math.Min(smallestSubarraySize, endIndices[i] - startIndices[i] + 1);
                }
            }

            return smallestSubarraySize;
        }

        public static int FindShortestSubArray2(int[] nums)
        {
            Dictionary<int, int> startIndices = new Dictionary<int, int>();
            Dictionary<int, int> endIndices = new Dictionary<int, int>();
            Dictionary<int, int> counts = new Dictionary<int, int>();
            int maxCount = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (counts.ContainsKey(nums[i]))
                {
                    counts[nums[i]]++;
                }
                else
                {
                    counts.Add(nums[i], 1);
                }

                maxCount = Math.Max(maxCount, counts[nums[i]]);

                if (!startIndices.ContainsKey(nums[i]))
                {
                    startIndices.Add(nums[i], i);
                }

                endIndices[nums[i]] = i;

            }

            int smallestSubarraySize = int.MaxValue;

            foreach (var kvp in counts)
            {
                if (kvp.Value == maxCount)
                {
                    smallestSubarraySize = Math.Min(smallestSubarraySize, endIndices[kvp.Key] - startIndices[kvp.Key] + 1);
                }
            }

            return smallestSubarraySize;
        }
    }
}
