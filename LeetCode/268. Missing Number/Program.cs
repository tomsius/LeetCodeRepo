using System;

namespace _268._Missing_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 3, 0, 1 };
            Console.WriteLine(MissingNumber1(nums1));
            Console.WriteLine(MissingNumber2(nums1));

            int[] nums2 = { 0, 1 };
            Console.WriteLine(MissingNumber1(nums2));
            Console.WriteLine(MissingNumber2(nums2));

            int[] nums3 = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
            Console.WriteLine(MissingNumber1(nums3));
            Console.WriteLine(MissingNumber2(nums3));

            int[] nums4 = { 0 };
            Console.WriteLine(MissingNumber1(nums4));
            Console.WriteLine(MissingNumber2(nums4));
        }

        public static int MissingNumber1(int[] nums)
        {
            int xorResult = 0;

            for (int i = 1; i <= nums.Length; i++)
            {
                xorResult ^= i;
            }

            foreach (var num in nums)
            {
                xorResult ^= num;
            }

            return xorResult;
        }

        public static int MissingNumber2(int[] nums)
        {
            int xorResult = 0;

            for (int i = 1; i <= nums.Length; i++)
            {
                xorResult ^= i;
                xorResult ^= nums[i - 1];
            }

            return xorResult;
        }
    }
}
