using System;
using System.Collections.Generic;
using System.Linq;

namespace _1260._Shift_2D_Grid
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] grid1 = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 }
            };
            int k1 = 1;
            Print(ShiftGrid1(grid1, k1));
            grid1 = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 }
            };
            Print(ShiftGrid2(grid1, k1));

            int[][] grid2 = new int[][]
            {
                new int[] { 3, 8, 1, 9 },
                new int[] { 19, 7, 2, 5 },
                new int[] { 4, 6, 11, 10 },
                new int[] { 12, 0, 21, 13 }
            };
            int k2 = 4;
            Print(ShiftGrid1(grid2, k2));
            grid2 = new int[][]
            {
                new int[] { 3, 8, 1, 9 },
                new int[] { 19, 7, 2, 5 },
                new int[] { 4, 6, 11, 10 },
                new int[] { 12, 0, 21, 13 }
            };
            Print(ShiftGrid2(grid2, k2));

            int[][] grid3 = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 }
            };
            int k3 = 9;
            Print(ShiftGrid1(grid3, k3));
            grid3 = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 }
            };
            Print(ShiftGrid2(grid3, k3));

            int[][] grid4 = new int[][]
            {
                new int[] { 1 }
            };
            int k4 = 100;
            Print(ShiftGrid1(grid4, k4));
            grid4 = new int[][]
            {
                new int[] { 1 }
            };
            Print(ShiftGrid2(grid4, k4));

            int[][] grid5 = new int[][]
           {
                new int[] { 1 },
                new int[] { 2 },
                new int[] { 3 },
                new int[] { 4 },
                new int[] { 7 },
                new int[] { 6 },
                new int[] { 5 }
           };
            int k5 = 23;
            Print(ShiftGrid1(grid5, k5));
            grid5 = new int[][]
           {
                new int[] { 1 },
                new int[] { 2 },
                new int[] { 3 },
                new int[] { 4 },
                new int[] { 7 },
                new int[] { 6 },
                new int[] { 5 }
           };
            Print(ShiftGrid2(grid5, k5));
        }

        public static IList<IList<int>> ShiftGrid1(int[][] grid, int k)
        {
            List<int> values = new List<int>(grid.Length * grid[0].Length);
            grid.ToList().ForEach(x => values.AddRange(x));

            int startIndex = values.Count - k;

            if (startIndex < 0)
            {
                startIndex = values.Count - (k % values.Count);
            }

            int row = 0;
            int col = 0;

            for (int i = startIndex; i < values.Count; i++)
            {
                grid[row][col] = values[i];
                col++;

                if (col == grid[0].Length)
                {
                    col = 0;
                    row++;
                }
            }

            for (int i = 0; i < startIndex; i++)
            {
                grid[row][col] = values[i];
                col++;

                if (col == grid[0].Length)
                {
                    col = 0;
                    row++;
                }
            }

            return grid;
        }

        public static IList<IList<int>> ShiftGrid2(int[][] grid, int k)
        {
            int n = grid.Length * grid[0].Length;
            int[] values = new int[n];
            int index = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    values[(index + k) % n] = grid[i][j];
                    index++;
                }
            }

            IList<IList<int>> newGrid = new List<IList<int>>(n);

            for (int i = 0; i < grid.Length; i++)
            {
                IList<int> row = new List<int>();

                for (int j = 0; j < grid[i].Length; j++)
                {
                    row.Add(values[i * grid[i].Length + j]);
                }

                newGrid.Add(row);
            }

            return newGrid;
        }

        private static void Print(IList<IList<int>> grid)
        {
            foreach (var row in grid)
            {
                foreach (var col in row)
                {
                    Console.Write(col + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
