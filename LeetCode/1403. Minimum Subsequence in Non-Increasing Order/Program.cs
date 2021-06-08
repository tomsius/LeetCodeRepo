using System;
using System.Collections.Generic;
using System.Linq;

namespace _1403._Minimum_Subsequence_in_Non_Increasing_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 4, 3, 10, 9, 8 };
            Console.WriteLine(String.Join(", ", MinSubsequence(nums1)));

            int[] nums2 = { 4, 4, 7, 6, 7 };
            Console.WriteLine(String.Join(", ", MinSubsequence(nums2)));

            int[] nums3 = { 6 };
            Console.WriteLine(String.Join(", ", MinSubsequence(nums3)));
        }

        public static IList<int> MinSubsequence(int[] nums)
        {
            IList<int> subsequence = new List<int>(nums.Length);
            int sum = 0;
            Array.Sort(nums);

            foreach (var number in nums)
            {
                sum += number;
            }

            int newSum = 0;
            for (int i = nums.Length - 1; i >= 0 && newSum <= sum - newSum; i--)
            {
                subsequence.Add(nums[i]);
                newSum += nums[i];
            }

            return subsequence;
        }
    }
}
