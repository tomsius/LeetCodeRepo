using System;
using System.Collections.Generic;
using System.Linq;

namespace _1356._Sort_Integers_by_The_Number_of_1_Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            Console.WriteLine(String.Join(", ", SortByBits(arr1)));

            int[] arr2 = { 1024, 512, 256, 128, 64, 32, 16, 8, 4, 2, 1 };
            Console.WriteLine(String.Join(", ", SortByBits(arr2)));

            int[] arr3 = { 10000, 10000 };
            Console.WriteLine(String.Join(", ", SortByBits(arr3)));

            int[] arr4 = { 2, 3, 5, 7, 11, 13, 17, 19 };
            Console.WriteLine(String.Join(", ", SortByBits(arr4)));

            int[] arr5= { 10, 100, 1000, 10000 };
            Console.WriteLine(String.Join(", ", SortByBits(arr5)));
        }

        public static int[] SortByBits(int[] arr)
        {
            List<List<int>> onesByNumbers = new List<List<int>>(arr.Length);

            foreach (var number in arr)
            {
                int onesCountInBinary = GetOnesInBinary(number);
                List<int> onesByNumber = new List<int> { number, onesCountInBinary };
                onesByNumbers.Add(onesByNumber);
            }

            return onesByNumbers.OrderBy(item => item[1]).ThenBy(item => item[0]).Select(item => item[0]).ToArray();
        }

        private static int GetOnesInBinary(int number)
        {
            int ones = 0;

            while (number > 0)
            {
                int bit = number % 2;

                if (bit == 1)
                {
                    ones++;
                }

                number /= 2;
            }

            return ones;
        }
    }
}
