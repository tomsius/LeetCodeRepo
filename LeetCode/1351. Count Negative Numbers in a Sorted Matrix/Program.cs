using System;

namespace _1351._Count_Negative_Numbers_in_a_Sorted_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] grid1 = new int[][] 
            {
                new int[] { 4, 3, 2, -1 },
                new int[] { 3, 2, 1, -1 },
                new int[] { 1, 1 ,-1, -2 },
                new int[] { -1, -1, -2, -3 }
            };
            Console.WriteLine(CountNegatives1(grid1));
            Console.WriteLine(CountNegatives2(grid1));

            int[][] grid2 = new int[][]
            {
                new int[] { 3, 2 },
                new int[] { 1, 0 }
            };
            Console.WriteLine(CountNegatives1(grid2));
            Console.WriteLine(CountNegatives2(grid2));

            int[][] grid3 = new int[][]
            {
                new int[] { 1, -1 },
                new int[] { -1, -1 }
            };
            Console.WriteLine(CountNegatives1(grid3));
            Console.WriteLine(CountNegatives2(grid3));

            int[][] grid4 = new int[][]
            {
                new int[] { -1 }
            };
            Console.WriteLine(CountNegatives1(grid4));
            Console.WriteLine(CountNegatives2(grid4));
        }

        public static int CountNegatives1(int[][] grid)
        {
            int negatives = 0;

            foreach (var row in grid)
            {
                foreach (var value in row)
                {
                    if (value < 0)
                    {
                        negatives++;
                    }
                }
            }

            return negatives;
        }

        public static int CountNegatives2(int[][] grid)
        {
            int negatives = 0;
            int negativeStart = 0;

            for (int i = grid.Length - 1; i >= 0; i--)
            {
                if (grid[i][0] < 0)
                {
                    negatives += grid[i].Length;
                    continue;
                }

                while (negativeStart < grid[i].Length && grid[i][negativeStart] >= 0)
                {
                    negativeStart++;
                }

                for (int j = negativeStart; j < grid[i].Length; j++)
                {
                    negatives++;
                }
            }

            return negatives;
        }
    }
}
