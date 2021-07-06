using System;

namespace _1920._Build_Array_from_Permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 0, 2, 1, 5, 3, 4 };
            Console.WriteLine(String.Join(", ", BuildArray1(nums1)));
            Console.WriteLine(String.Join(", ", BuildArray2(nums1)));

            int[] nums2 = { 5, 0, 1, 2, 3, 4 };
            Console.WriteLine(String.Join(", ", BuildArray1(nums2)));
            Console.WriteLine(String.Join(", ", BuildArray2(nums2)));
        }

        public static int[] BuildArray1(int[] nums)
        {
            int[] ans = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                ans[i] = nums[nums[i]];
            }

            return ans;
        }

        public static int[] BuildArray2(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = nums[nums[i]];
            }

            return nums;
        }
    }
}
