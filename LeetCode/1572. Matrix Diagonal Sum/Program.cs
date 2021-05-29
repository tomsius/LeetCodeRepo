using System;

namespace _1572._Matrix_Diagonal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] mat1 = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 }
            };
            Console.WriteLine(DiagonalSum1(mat1));
            Console.WriteLine(DiagonalSum2(mat1));

            int[][] mat2 = new int[][]
            {
                new int[] { 1, 1, 1, 1 },
                new int[] { 1, 1, 1, 1 },
                new int[] { 1, 1, 1, 1 },
                new int[] { 1, 1, 1, 1 }
            };
            Console.WriteLine(DiagonalSum1(mat2));
            Console.WriteLine(DiagonalSum2(mat2));

            int[][] mat3 = new int[][]
            {
                new int[] { 5 }
            };
            Console.WriteLine(DiagonalSum1(mat3));
            Console.WriteLine(DiagonalSum2(mat3));
        }

        public static int DiagonalSum1(int[][] mat)
        {
            int sum = 0;

            for (int i = 0; i < mat.Length; i++)
            {
                sum += mat[i][i];
                sum += mat[i][mat.Length - i - 1];
            }

            if (mat.Length % 2 == 1)
            {
                int midIndex = mat.Length / 2;
                sum -= mat[midIndex][midIndex];
            }

            return sum;
        }

        public static int DiagonalSum2(int[][] mat)
        {
            int sum = 0;

            for (int i = 0; i < mat.Length; i++)
            {
                sum += mat[i][i];
                sum += mat[i][mat.Length - i - 1];
            }

            if (mat.Length % 2 == 1)
            {
                sum -= mat[mat.Length / 2][mat.Length / 2];
            }

            return sum;
        }
    }
}
