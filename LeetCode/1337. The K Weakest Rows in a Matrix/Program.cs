using System;
using System.Collections.Generic;
using System.Linq;

namespace _1337._The_K_Weakest_Rows_in_a_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] mat1 = new int[][]
            {
                new int[] { 1, 1, 0, 0, 0 },
                new int[] { 1, 1, 1, 1, 0 },
                new int[] { 1, 0, 0, 0, 0 },
                new int[] { 1, 1, 0, 0, 0 },
                new int[] { 1, 1, 1, 1, 1 }
            };
            int k1 = 3;
            Console.WriteLine(String.Join(", ", KWeakestRows(mat1, k1)));

            int[][] mat2 = new int[][]
            {
                new int[] { 1, 0, 0, 0 },
                new int[] { 1, 1, 1, 1 },
                new int[] { 1, 0, 0, 0 },
                new int[] { 1, 0, 0, 0 }
            };
            int k2 = 2;
            Console.WriteLine(String.Join(", ", KWeakestRows(mat2, k2)));
        }

        public static int[] KWeakestRows(int[][] mat, int k)
        {
            Dictionary<int, int> soldiersByRow = new Dictionary<int, int>(mat.Length);

            for (int row = 0; row < mat.Length; row++)
            {
                int soldiersCount = 0;

                int col = 0;
                while (col < mat[row].Length && mat[row][col] == 1)
                {
                    soldiersCount++;
                    col++;
                }

                soldiersByRow.Add(row, soldiersCount);
            }

            int[] keys = soldiersByRow.OrderBy(item => item.Value).ThenBy(item => item.Key).Take(k).Select(item => item.Key).ToArray();

            return keys;
        }
    }
}
