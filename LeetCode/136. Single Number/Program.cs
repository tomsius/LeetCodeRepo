using System;

namespace _136._Single_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 2, 2, 1 };
            Console.WriteLine(SingleNumber1(nums1));
            Console.WriteLine(SingleNumber2(nums1));

            int[] nums2 = { 4, 1, 2, 1, 2 };
            Console.WriteLine(SingleNumber1(nums2));
            Console.WriteLine(SingleNumber2(nums2));

            int[] nums3 = { 1 };
            Console.WriteLine(SingleNumber1(nums3));
            Console.WriteLine(SingleNumber2(nums3));
        }

        public static int SingleNumber1(int[] nums)
        {
            Array.Sort(nums);

            for (int i = 1; i < nums.Length; i++)
            {
                if (i == nums.Length - 1 && nums[i] != nums[i - 1])
                {
                    return nums[i];
                }

                if (nums[i] == nums[i - 1] || nums[i] == nums[i + 1])
                {
                    continue;
                }

                return nums[i];
            }

            return nums[0];
        }

        private static int SingleNumber2(int[] nums)
        {
            int xorResult = 0;

            foreach (var num in nums)
            {
                xorResult ^= num;
            }

            return xorResult;
        }
    }
}
