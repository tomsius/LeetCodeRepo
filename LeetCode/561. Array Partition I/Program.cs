using System;

namespace _561._Array_Partition_I
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 4, 3, 2 };
            Console.WriteLine(ArrayPairSum(nums1));

            int[] nums2 = { 6, 2, 6, 5, 1, 2 };
            Console.WriteLine(ArrayPairSum(nums2));
        }

        public static int ArrayPairSum(int[] nums)
        {
            Array.Sort(nums);
            int maxSum = 0;

            for (int i = 0; i < nums.Length; i += 2)
            {
                maxSum += nums[i];
            }

            return maxSum;
        }
    }
}
