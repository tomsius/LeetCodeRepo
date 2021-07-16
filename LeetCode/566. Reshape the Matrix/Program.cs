using System;

namespace _566._Reshape_the_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] mat1 = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 3, 4 }
            };
            int r1 = 1;
            int c1 = 4;
            Print(MatrixReshape(mat1, r1, c1));

            int[][] mat2 = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 3, 4 }
            };
            int r2 = 2;
            int c2 = 4;
            Print(MatrixReshape(mat2, r2, c2));

            int[][] mat3 = new int[][]
            {
                new int[] { 1, 2, 3, 4 }
            };
            int r3 = 2;
            int c3 = 2;
            Print(MatrixReshape(mat3, r3, c3));
        }

        public static int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            if (mat.Length * mat[0].Length != r * c)
            {
                return mat;
            }

            int[][] newMat = new int[r][];
            int oldMatRow = 0;
            int oldMatCol = 0;

            for (int row = 0; row < newMat.Length; row++)
            {
                newMat[row] = new int[c];

                for (int col = 0; col < c; col++)
                {
                    newMat[row][col] = mat[oldMatRow][oldMatCol];

                    if (oldMatCol + 1 < mat[oldMatRow].Length)
                    {
                        oldMatCol++;
                    }
                    else
                    {
                        oldMatRow++;
                        oldMatCol = 0;
                    }
                }
            }

            return newMat;
        }

        private static void Print(int[][] matrix)
        {
            foreach (var row in matrix)
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
