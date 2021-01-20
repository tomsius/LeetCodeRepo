using System;
using System.Collections.Generic;

namespace _1470._Shuffle_the_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 2, 5, 1, 3, 4, 7 };
            int n1 = 3;
            Console.WriteLine(string.Join(" ", Shuffle(nums1, n1)));

            int[] nums2 = { 1, 2, 3, 4, 4, 3, 2, 1 };
            int n2 = 4;
            Console.WriteLine(string.Join(" ", Shuffle(nums2, n2)));

            int[] nums3 = { 1, 1, 2, 2 };
            int n3 = 2;
            Console.WriteLine(string.Join(" ", Shuffle(nums3, n3)));

            Console.ReadKey();
        }

        public static int[] Shuffle(int[] nums, int n)
        {
            int[] result = new int[nums.Length];
            int current = 0;

            for (int i = 0; i < n; i++)
            {
                result[current++] = nums[i];
                result[current++] = nums[i + n];
            }

            return result;
        }
    }
}
