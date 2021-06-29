using System;
using System.Collections.Generic;
using System.Linq;

namespace _1030._Matrix_Cells_in_Distance_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows1 = 1;
            int cols1 = 2;
            int rCenter1 = 0;
            int cCenter1 = 0;
            Print(AllCellsDistOrder(rows1, cols1, rCenter1, cCenter1));

            int rows2 = 2;
            int cols2 = 2;
            int rCenter2 = 0;
            int cCenter2 = 1;
            Print(AllCellsDistOrder(rows2, cols2, rCenter2, cCenter2));

            int rows3 = 2;
            int cols3 = 3;
            int rCenter3 = 1;
            int cCenter3 = 2;
            Print(AllCellsDistOrder(rows3, cols3, rCenter3, cCenter3));
        }

        public static int[][] AllCellsDistOrder(int rows, int cols, int rCenter, int cCenter)
        {
            Dictionary<int[], int> distances = new Dictionary<int[], int>(rows * cols);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    int distance = Math.Abs(row - rCenter) + Math.Abs(col - cCenter);
                    int[] coordinates = { row, col };
                    distances.Add(coordinates, distance);
                }
            }

            var sortedCoordinates = distances.ToList();
            sortedCoordinates.Sort((x, y) => x.Value.CompareTo(y.Value));

            return sortedCoordinates.Select(x => x.Key).ToArray();
        }

        private static void Print(int[][] matrix)
        {
            foreach (var row in matrix)
            {
                Console.Write($"({row[0]}, {row[1]}) ");
            }
            Console.WriteLine();
        }
    }
}
