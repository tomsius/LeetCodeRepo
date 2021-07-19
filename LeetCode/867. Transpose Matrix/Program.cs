using System;
using System.Collections.Generic;

namespace _867._Transpose_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix1 = new int[][]
            {
                new int[] {  1, 2, 3 },
                new int[] {  4, 5, 6 },
                new int[] {  7, 8, 9 }
            };
            Print(Transpose1(matrix1));
            Print(Transpose2(matrix1));

            int[][] matrix2 = new int[][]
            {
                new int[] {  1, 2, 3 },
                new int[] {  4, 5, 6 }
            };
            Print(Transpose1(matrix2));
            Print(Transpose2(matrix2));
        }

        public static int[][] Transpose1(int[][] matrix)
        {
            int[][] newMatrix = new int[matrix[0].Length][];
            int newMatrixRow = 0;

            for (int col = 0; col < matrix[0].Length; col++)
            {
                int newMatrixCol = 0;
                newMatrix[newMatrixRow] = new int[matrix.Length];

                for (int row = 0; row < matrix.Length; row++)
                {
                    newMatrix[newMatrixRow][newMatrixCol] = matrix[row][col];
                    newMatrixCol++;
                }

                newMatrixRow++;
            }

            return newMatrix;
        }

        public static int[][] Transpose2(int[][] matrix)
        {
            int[][] newMatrix = new int[matrix[0].Length][];

            for (int col = 0; col < matrix[0].Length; col++)
            {
                newMatrix[col] = new int[matrix.Length];

                for (int row = 0; row < matrix.Length; row++)
                {
                    newMatrix[col][row] = matrix[row][col];
                }
            }

            return newMatrix;
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
