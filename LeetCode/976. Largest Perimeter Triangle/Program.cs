using System;

namespace _976._Largest_Perimeter_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 2, 1, 2 };
            Console.WriteLine(LargestPerimeter(nums1));

            int[] nums2 = { 1, 2, 1 };
            Console.WriteLine(LargestPerimeter(nums2));

            int[] nums3 = { 3, 2, 3, 4 };
            Console.WriteLine(LargestPerimeter(nums3));

            int[] nums4 = { 3, 6, 2, 3 };
            Console.WriteLine(LargestPerimeter(nums4));
        }

        public static int LargestPerimeter(int[] nums)
        {
            Array.Sort(nums);

            for (int i = nums.Length - 1; i >= 2; i--)
            {
                if (nums[i - 2] + nums[i - 1] > nums[i])
                {
                    return nums[i - 2] + nums[i - 1] + nums[i];
                }
            }

            return 0;
        }
    }
}
