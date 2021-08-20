using System;

namespace _1539._Kth_Missing_Positive_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 2, 3, 4, 7, 11 };
            int k1 = 5;
            Console.WriteLine(FindKthPositive(arr1, k1));

            int[] arr2 = { 1, 2, 3, 4 };
            int k2 = 2;
            Console.WriteLine(FindKthPositive(arr2, k2));
        }
        public static int FindKthPositive(int[] arr, int k)
        {
            int arrIndex = 0;
            int expectedNumber = 1;
            int missingNumber = 0;

            while (k > 0)
            {
                if (arrIndex == arr.Length)
                {
                    missingNumber = expectedNumber;
                    k--;
                }
                else if (arr[arrIndex] != expectedNumber)
                {
                    missingNumber = expectedNumber;
                    k--;
                }
                else
                {
                    arrIndex++;
                }

                expectedNumber++;
            }

            return missingNumber;
        }
    }
}
