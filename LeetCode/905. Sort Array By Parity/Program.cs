using System;
using System.Collections.Generic;

namespace _905._Sort_Array_By_Parity
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 1, 2, 4 };
            Console.WriteLine(string.Join(" ", SortArrayByParity1(nums)));
            Console.WriteLine(string.Join(" ", SortArrayByParity2(nums)));
        }

        public static int[] SortArrayByParity1(int[] nums)
        {
            List<int> evenNumbers = new List<int>(nums.Length);
            List<int> oddNumbers = new List<int>(nums.Length);
            List<int> result = new List<int>(nums.Length);

            foreach (var number in nums)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
                else
                {
                    oddNumbers.Add(number);
                }
            }

            foreach (var item in evenNumbers)
            {
                result.Add(item);
            }

            foreach (var item in oddNumbers)
            {
                result.Add(item);
            }

            return result.ToArray();
        }

        public static int[] SortArrayByParity2(int[] nums)
        {
            int[] result = new int[nums.Length];
            int positiveIndex = 0;
            int negativeIndex = nums.Length - 1;

            foreach (var number in nums)
            {
                if (number % 2 == 0)
                {
                    result[positiveIndex++] = number;
                }
                else
                {
                    result[negativeIndex--] = number;
                }
            }

            return result;
        }
    }
}
