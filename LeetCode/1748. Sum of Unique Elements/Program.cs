using System;
using System.Collections.Generic;

namespace _1748._Sum_of_Unique_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3, 2 };
            Console.WriteLine(SumOfUnique1(nums1));
            Console.WriteLine(SumOfUnique2(nums1));

            int[] nums2 = { 1, 1, 1, 1, 1 };
            Console.WriteLine(SumOfUnique1(nums2));
            Console.WriteLine(SumOfUnique2(nums2));

            int[] nums3 = { 1, 2, 3, 4, 5 };
            Console.WriteLine(SumOfUnique1(nums3));
            Console.WriteLine(SumOfUnique2(nums3));
        }

        public static int SumOfUnique1(int[] nums)
        {
            int sumOfUniqueNumber = 0;
            Dictionary<int, int> occurances = new Dictionary<int, int>();

            foreach (var number in nums)
            {
                if (!occurances.ContainsKey(number))
                {
                    occurances.Add(number, 1);
                }
                else
                {
                    occurances[number]++;
                }
            }

            foreach (var pair in occurances)
            {
                if (pair.Value == 1)
                {
                    sumOfUniqueNumber += pair.Key;
                }
            }

            return sumOfUniqueNumber;
        }

        public static int SumOfUnique2(int[] nums)
        {
            int sumOfUniqueNumber = 0;
            int[] occurances = new int[100];

            foreach (var number in nums)
            {
                occurances[number - 1]++;
            }

            for (int i = 0; i < occurances.Length; i++)
            {
                if (occurances[i] == 1)
                {
                    sumOfUniqueNumber += i + 1;
                }
            }

            return sumOfUniqueNumber;
        }
    }
}
