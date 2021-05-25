using System;

namespace _1588._Sum_of_All_Odd_Length_Subarrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = { 1, 4, 2, 5, 3 };
            Console.WriteLine(SumOddLengthSubarrays(input1));

            int[] input2 = { 1, 2 };
            Console.WriteLine(SumOddLengthSubarrays(input2));

            int[] input3 = { 10, 11, 12 };
            Console.WriteLine(SumOddLengthSubarrays(input3));
        }

        public static int SumOddLengthSubarrays(int[] arr)
        {
            int allSubarraysSum = 0;

            for (int i = 1; i <= arr.Length; i += 2)
            {
                allSubarraysSum += FindSubarraysSum(arr, i);
            }

            return allSubarraysSum;
        }

        private static int FindSubarraysSum(int[] arr, int subarrayLength)
        {
            int subarraysSum = 0;

            for (int i = 0; i <= arr.Length - subarrayLength; i++)
            {
                subarraysSum += FindSubarraysSum(arr, i, i + subarrayLength);
            }

            return subarraysSum;
        }

        private static int FindSubarraysSum(int[] arr, int start, int end)
        {
            int sum = 0;

            for (int i = start; i < end; i++)
            {
                sum += arr[i];
            }

            return sum;
        }
    }
}
