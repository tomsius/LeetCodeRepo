using System;

namespace _1051._Height_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] heights1 = { 1, 1, 4, 2, 1, 3 };
            Console.WriteLine(HeightChecker(heights1));

            int[] heights2 = { 5, 1, 2, 3, 4 };
            Console.WriteLine(HeightChecker(heights2));

            int[] heights3 = { 1, 2, 3, 4, 5 };
            Console.WriteLine(HeightChecker(heights3));
        }

        public static int HeightChecker(int[] heights)
        {
            int[] expected = new int[heights.Length];
            Array.Copy(heights, expected, heights.Length);
            Array.Sort(expected);

            int nonMatchingCount = 0;

            for (int i = 0; i < heights.Length; i++)
            {
                if (heights[i] != expected[i])
                {
                    nonMatchingCount++;
                }
            }

            return nonMatchingCount;
        }
    }
}
