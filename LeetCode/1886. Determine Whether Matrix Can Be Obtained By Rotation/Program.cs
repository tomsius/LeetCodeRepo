using System;

namespace _1886._Determine_Whether_Matrix_Can_Be_Obtained_By_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] mat1 = new int[][]
            {
                new int[] { 0, 1 },
                new int[] { 1, 0 }
            };
            int[][] target1 = new int[][]
            {
                new int[] { 1, 0 },
                new int[] { 0, 1 }
            };
            Console.WriteLine(FindRotation(mat1, target1));

            int[][] mat2 = new int[][]
            {
                new int[] { 0, 1 },
                new int[] { 1, 1 }
            };
            int[][] target2 = new int[][]
            {
                new int[] { 1, 0 },
                new int[] { 0, 1 }
            };
            Console.WriteLine(FindRotation(mat2, target2));

            int[][] mat3 = new int[][]
            {
                new int[] { 0, 0, 0 },
                new int[] { 0, 1, 0 },
                new int[] { 1, 1, 1 }
            };
            int[][] target3 = new int[][]
            {
                new int[] { 1, 1, 1 },
                new int[] { 0, 1, 0 },
                new int[] { 0, 0, 0 }
            };
            Console.WriteLine(FindRotation(mat3, target3));
        }

        public static bool FindRotation(int[][] mat, int[][] target)
        {
            for (int i = 0; i < 4; i++)
            {
                if (IsSameMatrix(mat, target))
                {
                    return true;
                }

                RotateMatrix(mat);
            }

            return false;
        }

        private static void RotateMatrix(int[][] mat)
        {
            for (int row = 0; row < mat.Length / 2; row++)
            {
                for (int col = row; col < mat.Length - row - 1; col++)
                {
                    int temp = mat[row][col];
                    mat[row][col] = mat[mat.Length - col - 1][row];
                    mat[mat.Length - col - 1][row] = mat[mat.Length - row - 1][mat.Length - col - 1];
                    mat[mat.Length - row - 1][mat.Length - col - 1] = mat[col][mat.Length - row - 1];
                    mat[col][mat.Length - row - 1] = temp;
                }
            }
        }

        private static bool IsSameMatrix(int[][] mat, int[][] target)
        {
            for (int row = 0; row < mat.Length; row++)
            {
                for (int col = 0; col < mat[row].Length; col++)
                {
                    if (mat[row][col] != target[row][col])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
