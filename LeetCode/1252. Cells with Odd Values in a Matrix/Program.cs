using System;
using System.Linq;

namespace _1252._Cells_with_Odd_Values_in_a_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int m1 = 2;
            int n1 = 3;
            int[][] indices1 = new int[][]
            {
                new int[] { 0, 1 },
                new int[] { 1, 1 }
            };
            Console.WriteLine(OddCells(m1, n1, indices1));

            int m2 = 2;
            int n2 = 2;
            int[][] indices2 = new int[][]
            {
                new int[] { 1, 1 },
                new int[] { 0, 0 }
            };
            Console.WriteLine(OddCells(m2, n2, indices2));
        }

        public static int OddCells(int m, int n, int[][] indices)
        {
            int[,] matrix = new int[m, n];

            for (int i = 0; i < indices.Length; i++)
            {
                int rowToInc = indices[i][0];
                int colToInc = indices[i][1];

                for (int row = 0; row < m; row++)
                {
                    matrix[row, colToInc]++;
                }

                for (int col = 0; col < n; col++)
                {
                    matrix[rowToInc, col]++;
                }
            }

            int oddValueCount = 0;

            foreach (var item in matrix)
            {
                if (item % 2 == 1)
                {
                    oddValueCount++;
                }
            }

            return oddValueCount;
        }
    }
}
