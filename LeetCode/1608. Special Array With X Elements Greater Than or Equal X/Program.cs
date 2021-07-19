using System;

namespace _1608._Special_Array_With_X_Elements_Greater_Than_or_Equal_X
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 3, 5 };
            Console.WriteLine(SpecialArray(nums1));

            int[] nums2 = { 0, 0 };
            Console.WriteLine(SpecialArray(nums2));

            int[] nums3 = { 0, 4, 3, 0, 4 };
            Console.WriteLine(SpecialArray(nums3));

            int[] nums4 = { 3, 6, 7, 7, 0 };
            Console.WriteLine(SpecialArray(nums4));
        }

        public static int SpecialArray(int[] nums)
        {
            Array.Sort(nums);

            for (int x = 0; x <= nums[^1]; x++)
            {
                int count = GetGreaterThanOrEqualToCount(nums, x);

                if (x == count)
                {
                    return x;
                }
            }

            return -1;
        }

        private static int GetGreaterThanOrEqualToCount(int[] nums, int x)
        {
            int index = 0;

            while (index < nums.Length && x > nums[index])
            {
                index++;
            }

            return nums.Length - index;
        }
    }
}
