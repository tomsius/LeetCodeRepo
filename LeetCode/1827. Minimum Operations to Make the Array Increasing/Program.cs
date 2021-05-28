using System;

namespace _1827._Minimum_Operations_to_Make_the_Array_Increasing
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 1, 1 };
            Console.WriteLine(MinOperations1(nums1));
            nums1 = new int[]{ 1, 1, 1 };
            Console.WriteLine(MinOperations2(nums1));

            int[] nums2 = { 1, 5, 2, 4, 1 };
            Console.WriteLine(MinOperations1(nums2));
            nums2 = new int[]{ 1, 5, 2, 4, 1 };
            Console.WriteLine(MinOperations2(nums2));

            int[] nums3 = { 8 };
            Console.WriteLine(MinOperations1(nums3));
            nums3 = new int[]{ 8 };
            Console.WriteLine(MinOperations2(nums3));
        }

        public static int MinOperations1(int[] nums)
        {
            int totalOperations = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                while (nums[i - 1] >= nums[i])
                {
                    nums[i]++;
                    totalOperations++;
                }
            }

            return totalOperations;
        }

        public static int MinOperations2(int[] nums)
        {
            int totalOperations = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] >= nums[i])
                {
                    int diff = nums[i - 1] - nums[i] + 1;
                    nums[i] += diff;
                    totalOperations += diff;
                }
            }

            return totalOperations;
        }
    }
}
