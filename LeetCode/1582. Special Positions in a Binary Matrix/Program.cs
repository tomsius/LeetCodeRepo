using System;

namespace _1582._Special_Positions_in_a_Binary_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] mat1 = new int[][]
            {
                new int[] { 1, 0, 0 },
                new int[] { 0, 0, 1 },
                new int[] { 1, 0, 0 }
            };
            Console.WriteLine(NumSpecial(mat1));

            int[][] mat2 = new int[][]
            {
                new int[] { 1, 0, 0 },
                new int[] { 0, 1, 0 },
                new int[] { 0, 0, 1 }
            };
            Console.WriteLine(NumSpecial(mat2));

            int[][] mat3 = new int[][]
            {
                new int[] { 0, 0, 0, 1 },
                new int[] { 1, 0, 0, 0 },
                new int[] { 0, 1, 1, 0 },
                new int[] { 0, 0, 0, 0 }
            };
            Console.WriteLine(NumSpecial(mat3));

            int[][] mat4 = new int[][]
            {
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 1, 0, 0, 0, 0 },
                new int[] { 0, 1, 0, 0, 0 },
                new int[] { 0, 0, 1, 0, 0 },
                new int[] { 0, 0, 0, 1, 1 },
            };
            Console.WriteLine(NumSpecial(mat4));
        }

        public static int NumSpecial(int[][] mat)
        {
            int specialPositionCount = 0;

            for (int row = 0; row < mat.Length; row++)
            {
                for (int col = 0; col < mat[row].Length; col++)
                {
                    if (mat[row][col] == 1)
                    {
                        if (IsSpecialPosition(mat, row, col))
                        {
                            specialPositionCount++;
                        }
                    }
                }
            }

            return specialPositionCount;
        }

        private static bool IsSpecialPosition(int[][] mat, int i, int j)
        {
            for (int row = 0; row < mat.Length; row++)
            {
                if (row != i && mat[row][j] == 1)
                {
                    return false;
                }
            }

            for (int col = 0; col < mat[i].Length; col++)
            {
                if (col != j && mat[i][col] == 1)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
