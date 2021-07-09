using System;
using System.Collections.Generic;
using System.Linq;

namespace _1399._Count_Largest_Group
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 13;
            Console.WriteLine(CountLargestGroup1(n1));
            Console.WriteLine(CountLargestGroup2(n1));

            int n2 = 2;
            Console.WriteLine(CountLargestGroup1(n2));
            Console.WriteLine(CountLargestGroup2(n2));

            int n3 = 15;
            Console.WriteLine(CountLargestGroup1(n3));
            Console.WriteLine(CountLargestGroup2(n3));

            int n4 = 24;
            Console.WriteLine(CountLargestGroup1(n4));
            Console.WriteLine(CountLargestGroup2(n4));

            int n5 = 46;
            Console.WriteLine(CountLargestGroup1(n5));
            Console.WriteLine(CountLargestGroup2(n5));
        }

        public static int CountLargestGroup1(int n)
        {
            Dictionary<int, List<int>> groupsByDigitSum = new Dictionary<int, List<int>>();
            int largestGroupSize = 0;

            for (int i = 1; i <= n; i++)
            {
                int digitSum = countDigitSum(i);

                if (groupsByDigitSum.ContainsKey(digitSum))
                {
                    groupsByDigitSum[digitSum].Add(i);
                    largestGroupSize = Math.Max(largestGroupSize, groupsByDigitSum[digitSum].Count);
                }
                else
                {
                    groupsByDigitSum.Add(digitSum, new List<int> { i });
                    largestGroupSize = Math.Max(largestGroupSize, 1);
                }
            }

            return groupsByDigitSum.Count(x => x.Value.Count == largestGroupSize);
        }

        public static int CountLargestGroup2(int n)
        {
            Dictionary<int, int> groupsByDigitSum = new Dictionary<int, int>();

            for (int i = 1; i <= n; i++)
            {
                int digitSum = countDigitSum(i);

                if (groupsByDigitSum.ContainsKey(digitSum))
                {
                    groupsByDigitSum[digitSum]++;
                }
                else
                {
                    groupsByDigitSum.Add(digitSum, 1);
                }
            }

            return groupsByDigitSum.Count(x => x.Value == groupsByDigitSum.Values.Max());
        }

        private static int countDigitSum(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }
    }
}
