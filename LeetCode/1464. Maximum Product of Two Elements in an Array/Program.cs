using System;

namespace _1464._Maximum_Product_of_Two_Elements_in_an_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 3, 4, 5, 2 };
            Console.WriteLine(MaxProduct(nums1));

            int[] nums2 = { 1, 5, 4, 5 };
            Console.WriteLine(MaxProduct(nums2));

            int[] nums3 = { 3, 7 };
            Console.WriteLine(MaxProduct(nums3));

            int[] nums4 = { 10, 2, 5, 2 };
            Console.WriteLine(MaxProduct(nums4));
        }

        public static int MaxProduct(int[] nums)
        {
            int max1 = int.MinValue;
            int max2 = int.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= max1)
                {
                    max2 = max1;
                    max1 = nums[i];
                }
                else if (nums[i] > max2)
                {
                    max2 = nums[i];
                }
            }

            return (max1 - 1) * (max2 - 1);
        }
    }
}
