using System;

namespace _1800._Maximum_Ascending_Subarray_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 10, 20, 30, 5, 10, 50 };
            Console.WriteLine(MaxAscendingSum(nums1));

            int[] nums2 = { 10, 20, 30, 40, 50 };
            Console.WriteLine(MaxAscendingSum(nums2));

            int[] nums3 = { 12, 17, 15, 13, 10, 11, 12 };
            Console.WriteLine(MaxAscendingSum(nums3));

            int[] nums4 = { 100, 10, 1 };
            Console.WriteLine(MaxAscendingSum(nums4));
        }

        public static int MaxAscendingSum(int[] nums)
        {
            int maximumSum = nums[0];
            int ascendingSum = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                while (i < nums.Length && nums[i - 1] < nums[i])
                {
                    ascendingSum += nums[i];
                    i++;
                }

                maximumSum = Math.Max(maximumSum, ascendingSum);

                if (i < nums.Length)
                {
                    ascendingSum = nums[i]; 
                }
            }

            return maximumSum;
        }
    }
}
