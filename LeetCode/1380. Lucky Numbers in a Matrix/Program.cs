using System;
using System.Collections.Generic;
using System.Linq;

namespace _1380._Lucky_Numbers_in_a_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix1 = new int[][] 
            {
                new int[] { 3, 7, 8 },
                new int[] { 9, 11, 13 },
                new int[] { 15, 16, 17 }
            };
            Console.WriteLine(String.Join(", ", LuckyNumbers(matrix1)));

            int[][] matrix2 = new int[][] 
            {
                new int[] { 1, 10, 4, 2 },
                new int[] { 9, 3, 8, 7 },
                new int[] { 15, 16, 17, 12 }
            };
            Console.WriteLine(String.Join(", ", LuckyNumbers(matrix2)));

            int[][] matrix3 = new int[][]
            {
                new int[] { 7, 8 },
                new int[] { 1, 2 }
            };
            Console.WriteLine(String.Join(", ", LuckyNumbers(matrix3)));
        }

        public static IList<int> LuckyNumbers(int[][] matrix)
        {
            IList<int> luckyNumbers = new List<int>();
            int[] minimumsByRow = new int[matrix.Length];
            int[] maximumsByColumn = new int[matrix[0].Length];

            Array.Fill(minimumsByRow, int.MaxValue);
            Array.Fill(maximumsByColumn, int.MinValue);

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int column = 0; column < matrix[row].Length; column++)
                {
                    if (matrix[row][column] < minimumsByRow[row])
                    {
                        minimumsByRow[row] = matrix[row][column];
                    }

                    if (matrix[row][column] > maximumsByColumn[column])
                    {
                        maximumsByColumn[column] = matrix[row][column];
                    }
                }
            }

            foreach (var potentialLuckyNumber in minimumsByRow)
            {
                if (maximumsByColumn.Contains(potentialLuckyNumber))
                {
                    luckyNumbers.Add(potentialLuckyNumber);
                }
            }

            return luckyNumbers;
        }
    }
}
