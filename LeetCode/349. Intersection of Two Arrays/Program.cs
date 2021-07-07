using System;
using System.Collections.Generic;
using System.Linq;

namespace _349._Intersection_of_Two_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums11 = { 1, 2, 2, 1 };
            int[] nums21 = { 2, 2 };
            Console.WriteLine(String.Join(", ", Intersection1(nums11, nums21)));
            Console.WriteLine(String.Join(", ", Intersection2(nums11, nums21)));

            int[] nums12 = { 4, 9, 5 };
            int[] nums22 = { 9, 4, 9, 8, 4 };
            Console.WriteLine(String.Join(", ", Intersection1(nums12, nums22)));
            Console.WriteLine(String.Join(", ", Intersection2(nums12, nums22)));
        }

        public static int[] Intersection1(int[] nums1, int[] nums2)
        {
            HashSet<int> intersection = new HashSet<int>();

            foreach (var num in nums1)
            {
                if (nums2.Contains(num))
                {
                    intersection.Add(num);
                }
            }

            return intersection.ToArray();
        }

        private static int[] Intersection2(int[] nums1, int[] nums2)
        {
            Array.Sort(nums1);
            Array.Sort(nums2);

            int firstIndex = 0;
            int secondIndex = 0;
            HashSet<int> intersection = new HashSet<int>();

            while (firstIndex < nums1.Length && secondIndex < nums2.Length)
            {
                if (nums1[firstIndex] == nums2[secondIndex])
                {
                    intersection.Add(nums1[firstIndex]);
                    firstIndex++;
                    secondIndex++;
                }
                else if (nums1[firstIndex] > nums2[secondIndex])
                {
                    secondIndex++;
                }
                else
                {
                    firstIndex++;
                }
            }

            return intersection.ToArray();
        }
    }
}
