using System;
using System.Collections.Generic;

namespace _1863._Sum_of_All_Subset_XOR_Totals
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 3 };
            Console.WriteLine(SubsetXORSum1(nums1));
            Console.WriteLine(SubsetXORSum2(nums1));

            int[] nums2 = { 5, 1, 6 };
            Console.WriteLine(SubsetXORSum1(nums2));
            Console.WriteLine(SubsetXORSum2(nums2));

            int[] nums3 = { 3, 4, 5, 6, 7, 8 };
            Console.WriteLine(SubsetXORSum1(nums3));
            Console.WriteLine(SubsetXORSum2(nums3));
        }

        public static int SubsetXORSum1(int[] nums)
        {
            List<List<int>> allSubsets = new List<List<int>>();
            List<int> subset = new List<int>();

            FillSubsets(nums, allSubsets, subset, 0);

            int xorSum = 0;

            for (int i = 0; i < allSubsets.Count; i++)
            {
                int xorResult = 0;

                for (int j = 0; j < allSubsets[i].Count; j++)
                {
                    xorResult ^= allSubsets[i][j];
                }

                xorSum += xorResult;
            }

            return xorSum;
        }

        private static void FillSubsets(int[] nums, List<List<int>> allSubsets, List<int> subset, int index)
        {
            int[] subsetCopy = new int[subset.Count];
            subset.CopyTo(subsetCopy);
            allSubsets.Add(new List<int>(subsetCopy));

            for (int i = index; i < nums.Length; i++)
            {
                subset.Add(nums[i]);
                FillSubsets(nums, allSubsets, subset, i + 1);
                subset.RemoveAt(subset.Count - 1);
            }
        }

        public static int SubsetXORSum2(int[] nums)
        {
            int possibleSubsetsCount = (int)Math.Pow(2, nums.Length);
            int xorSum = 0;

            for (int i = 0; i < possibleSubsetsCount; i++)
            {
                int xorResult = 0;

                for (int j = 0; j < nums.Length; j++)
                {
                    if ((i & (1 << j)) >= 1)
                    {
                        xorResult ^= nums[j]; 
                    }
                }

                xorSum += xorResult;
            }

            return xorSum;
        }
    }
}
