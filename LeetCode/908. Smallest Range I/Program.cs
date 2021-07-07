using System;

namespace _908._Smallest_Range_I
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1 };
            int k1 = 0;
            Console.WriteLine(SmallestRangeI1(nums1, k1));
            Console.WriteLine(SmallestRangeI2(nums1, k1));

            int[] nums2 = { 0, 10 };
            int k2 = 2;
            Console.WriteLine(SmallestRangeI1(nums2, k2));
            Console.WriteLine(SmallestRangeI2(nums2, k2));

            int[] nums3 = { 1, 3, 6 };
            int k3 = 3;
            Console.WriteLine(SmallestRangeI1(nums3, k3));
            Console.WriteLine(SmallestRangeI2(nums3, k3));

            int[] nums4 = { 2, 7, 2 };
            int k4 = 1;
            Console.WriteLine(SmallestRangeI1(nums4, k4));
            Console.WriteLine(SmallestRangeI2(nums4, k4));
        }

        public static int SmallestRangeI1(int[] nums, int k)
        {
            Array.Sort(nums);

            int min = nums[0];
            int max = nums[nums.Length - 1];

            if (Math.Abs(max - min) <= 2 * k)
            {
                return 0;
            }

            return (max - k) - (min + k);
        }

        public static int SmallestRangeI2(int[] nums, int k)
        {
            int min = int.MaxValue;
            int max = int.MinValue;

            foreach (var num in nums)
            {
                min = Math.Min(num, min);
                max = Math.Max(num, max);
            }

            return Math.Abs(max - min) <= 2 * k ? 0 : max - min - 2 * k;
        }
    }
}
