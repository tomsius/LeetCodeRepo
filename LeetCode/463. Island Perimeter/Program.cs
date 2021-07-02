using System;

namespace _463._Island_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] grid1 = new int[][]
            {
                new int[] { 0, 1, 0, 0 },
                new int[] { 1, 1, 1, 0 },
                new int[] { 0, 1, 0, 0 },
                new int[] { 1, 1, 0, 0 }
            };
            Console.WriteLine(IslandPerimeter(grid1));

            int[][] grid2 = new int[][]
            {
                new int[] { 1 }
            };
            Console.WriteLine(IslandPerimeter(grid2));

            int[][] grid3 = new int[][]
            {
                new int[] { 1, 0 }
            };
            Console.WriteLine(IslandPerimeter(grid3));
        }

        public static int IslandPerimeter(int[][] grid)
        {
            int perimeter = 0;

            for (int row = 0; row < grid.Length; row++)
            {
                for (int col = 0; col < grid[row].Length; col++)
                {
                    if (grid[row][col] == 1)
                    {
                        int connectedIslandCells = GetConnectedIslandCellsCount(grid, row, col);
                        perimeter += 4 - connectedIslandCells;
                    }
                }
            }

            return perimeter;
        }

        private static int GetConnectedIslandCellsCount(int[][] grid, int row, int col)
        {
            int connectedIslandCells = 0;

            if (row > 0 && grid[row - 1][col] == 1)
            {
                connectedIslandCells++;
            }

            if (row < grid.Length - 1 && grid[row + 1][col] == 1)
            {
                connectedIslandCells++;
            }

            if (col > 0 && grid[row][col - 1] == 1)
            {
                connectedIslandCells++;
            }

            if (col < grid[row].Length - 1 && grid[row][col + 1] == 1)
            {
                connectedIslandCells++;
            }

            return connectedIslandCells;
        }
    }
}
