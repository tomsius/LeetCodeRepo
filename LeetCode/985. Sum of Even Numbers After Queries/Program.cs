using System;
using System.Linq;

namespace _985._Sum_of_Even_Numbers_After_Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3, 4 };
            int[][] queries1 = new int[][] 
            {
                new int[]{ 1, 0 },
                new int[]{ -3, 1 },
                new int[]{ -4, 0 },
                new int[]{ 2, 3 },
            };
            Console.WriteLine(String.Join(", ", SumEvenAfterQueries(nums1, queries1)));
        }

        public static int[] SumEvenAfterQueries(int[] nums, int[][] queries)
        {
            int[] answer = new int[queries.Length];
            int evenValuesSum = GetEvenValuesSum(nums);

            for (int i = 0; i < queries.Length; i++)
            {
                int value = queries[i][0];
                int index = queries[i][1];

                if (nums[index] % 2 == 0)
                {
                    evenValuesSum -= nums[index];
                }

                nums[index] += value;

                if (nums[index] % 2 == 0)
                {
                    evenValuesSum += nums[index];
                }

                answer[i] = evenValuesSum;
            }

            return answer;
        }

        private static int GetEvenValuesSum(int[] nums)
        {
            int sum = 0;

            foreach (var num in nums)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }

            return sum;
        }
    }
}
