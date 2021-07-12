using System;

namespace _1929._Concatenation_of_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 1 };
            Console.WriteLine(String.Join(", ", GetConcatenation(nums1)));

            int[] nums2 = { 1, 3, 2, 1 };
            Console.WriteLine(String.Join(", ", GetConcatenation(nums2)));
        }

        public static int[] GetConcatenation(int[] nums)
        {
            int[] ans = new int[nums.Length * 2];

            for (int i = 0; i < nums.Length; i++)
            {
                ans[i] = nums[i];
                ans[i + nums.Length] = nums[i];
            }

            return ans;
        }
    }
}
