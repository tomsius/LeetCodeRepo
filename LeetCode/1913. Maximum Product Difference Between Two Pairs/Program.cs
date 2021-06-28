using System;

namespace _1913._Maximum_Product_Difference_Between_Two_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 5, 6, 2, 7, 4 };
            Console.WriteLine(MaxProductDifference(nums1));

            int[] nums2 = { 4, 2, 5, 9, 7, 4, 8 };
            Console.WriteLine(MaxProductDifference(nums2));
        }

        public static int MaxProductDifference(int[] nums)
        {
            Array.Sort(nums);

            return (nums[nums.Length - 1] * nums[nums.Length - 2]) - (nums[0] * nums[1]);
        }
    }
}
