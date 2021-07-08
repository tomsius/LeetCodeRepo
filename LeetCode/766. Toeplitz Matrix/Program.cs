using System;
using System.Collections.Generic;

namespace _766._Toeplitz_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix1 = new int[][]
            {
                new int[] { 1, 2, 3, 4 },
                new int[] { 5, 1, 2, 3 },
                new int[] { 9, 5, 1, 2 }
            };
            Console.WriteLine(IsToeplitzMatrix1(matrix1));
            Console.WriteLine(IsToeplitzMatrix2(matrix1));

            int[][] matrix2 = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 2, 2 }
            };
            Console.WriteLine(IsToeplitzMatrix1(matrix2));
            Console.WriteLine(IsToeplitzMatrix2(matrix2));

            int[][] matrix3 = new int[][]
            {
                new int[] { 18 },
                new int[] { 66 }
            };
            Console.WriteLine(IsToeplitzMatrix1(matrix3));
            Console.WriteLine(IsToeplitzMatrix2(matrix3));
        }

        public static bool IsToeplitzMatrix1(int[][] matrix)
        {
            for (int i = 1; i < matrix.Length; i++)
            {
                for (int j = 1; j < matrix[i].Length; j++)
                {
                    if (matrix[i - 1][j - 1] != matrix[i][j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private static bool IsToeplitzMatrix2(int[][] matrix)
        {
            Dictionary<int, int> diagonals = new Dictionary<int, int>();

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    int diagonalKey = row - col;

                    if (diagonals.ContainsKey(diagonalKey))
                    {
                        return diagonals[diagonalKey] == matrix[row][col];
                    }
                    else
                    {
                        diagonals.Add(diagonalKey, matrix[row][col]);
                    }
                }
            }

            return true;
        }
    }
}
