using System;

namespace _704._Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { -1, 0, 3, 5, 9, 12 };
            int target1 = 9;
            Console.WriteLine(Search(nums1, target1));

            int[] nums2 = { -1, 0, 3, 5, 9, 12 };
            int target2 = 2;
            Console.WriteLine(Search(nums2, target2));
        }

        public static int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int middle = left + (right - left) / 2;

                if (nums[middle] == target)
                {
                    return middle;
                }

                if (nums[middle] > target)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }

            return -1;
        }
    }
}
