using System;

namespace _892._Surface_Area_of_3D_Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] grid1 = new int[][]
            {
                new int[] { 2 }
            };
            Console.WriteLine(SurfaceArea(grid1));

            int[][] grid2 = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 3, 4 }
            };
            Console.WriteLine(SurfaceArea(grid2));

            int[][] grid3 = new int[][]
            {
                new int[] { 1, 0 },
                new int[] { 0, 2 }
            };
            Console.WriteLine(SurfaceArea(grid3));

            int[][] grid4 = new int[][]
            {
                new int[] { 1, 1, 1 },
                new int[] { 1, 0, 1 },
                new int[] { 1, 1, 1 }
            };
            Console.WriteLine(SurfaceArea(grid4));

            int[][] grid5 = new int[][]
            {
                new int[] { 2, 2, 2 },
                new int[] { 2, 1, 2 },
                new int[] { 2, 2, 2 }
            };
            Console.WriteLine(SurfaceArea(grid5));
        }

        public static int SurfaceArea(int[][] grid)
        {
            int areaSum = 0;

            for (int row = 0; row < grid.Length; row++)
            {
                for (int col = 0; col < grid[row].Length; col++)
                {
                    // sum bottom and top
                    if (grid[row][col] != 0)
                    {
                        areaSum += 2; 
                    }

                    // first row
                    if (row == 0)
                    {
                        areaSum += grid[row][col];
                    }

                    // last row
                    if (row == grid.Length - 1)
                    {
                        areaSum += grid[row][col];
                    }

                    // first column
                    if (col == 0)
                    {
                        areaSum += grid[row][col];
                    }

                    // last column
                    if (col == grid[row].Length - 1)
                    {
                        areaSum += grid[row][col];
                    }

                    // check above
                    if (row > 0)
                    {
                        if (grid[row][col] > grid[row - 1][col])
                        {
                            areaSum += grid[row][col] - grid[row - 1][col];
                        }
                    }

                    // check below
                    if (row < grid.Length - 1)
                    {
                        if (grid[row][col] > grid[row + 1][col])
                        {
                            areaSum += grid[row][col] - grid[row + 1][col];
                        }
                    }

                    // check left
                    if (col > 0)
                    {
                        if (grid[row][col] > grid[row][col - 1])
                        {
                            areaSum += grid[row][col] - grid[row][col - 1];
                        }
                    }

                    // check right
                    if (col < grid[row].Length - 1)
                    {
                        if (grid[row][col] > grid[row][col + 1])
                        {
                            areaSum += grid[row][col] - grid[row][col + 1];
                        }
                    }
                }
            }

            return areaSum;
        }
    }
}
