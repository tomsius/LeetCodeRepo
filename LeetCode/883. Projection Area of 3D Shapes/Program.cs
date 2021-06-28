using System;

namespace _883._Projection_Area_of_3D_Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] grid1 = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 3, 4 }
            };
            Console.WriteLine(ProjectionArea(grid1));

            int[][] grid2 = new int[][]
            {
                new int[] { 2 }
            };
            Console.WriteLine(ProjectionArea(grid2));

            int[][] grid3 = new int[][]
            {
                new int[] { 1, 0 },
                new int[] { 0, 2 }
            };
            Console.WriteLine(ProjectionArea(grid3));

            int[][] grid4 = new int[][]
            {
                new int[] { 1, 1, 1 },
                new int[] { 1, 0, 1 },
                new int[] { 1, 1, 1 }
            };
            Console.WriteLine(ProjectionArea(grid4));

            int[][] grid5 = new int[][]
            {
                new int[] { 2, 2, 2 },
                new int[] { 2, 1, 2 },
                new int[] { 2, 2, 2 }
            };
            Console.WriteLine(ProjectionArea(grid5));
        }

        public static int ProjectionArea(int[][] grid)
        {
            int xyArea = 0;
            int xzArea = 0;
            int yzArea = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                xyArea += FindPositiveCountInRow(grid, i);
                xzArea += MaxInSameRow(grid, i);
                yzArea += MaxInSameColumn(grid, i);
            }

            return xyArea + xzArea + yzArea;
        }

        private static int FindPositiveCountInRow(int[][] grid, int row)
        {
            int positives = 0;

            for (int column = 0; column < grid[row].Length; column++)
            {
                if (grid[row][column] > 0)
                {
                    positives++;
                }
            }

            return positives;
        }

        private static int MaxInSameRow(int[][] grid, int row)
        {
            int maxHeight = int.MinValue;

            for (int column = 0; column < grid[row].Length; column++)
            {
                if (grid[row][column] > maxHeight)
                {
                    maxHeight = grid[row][column];
                }
            }

            return maxHeight;
        }

        private static int MaxInSameColumn(int[][] grid, int column)
        {
            int maxHeight = int.MinValue;

            for (int row = 0; row < grid.Length; row++)
            {
                if (grid[row][column] > maxHeight)
                {
                    maxHeight = grid[row][column];
                }
            }

            return maxHeight;
        }
    }
}
