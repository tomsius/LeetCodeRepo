using System;
using System.Collections.Generic;
using System.Linq;

namespace _118._Pascal_s_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int numRows1 = 5;
            Print(Generate1(numRows1));
            Print(Generate2(numRows1));

            int numRows2 = 1;
            Print(Generate1(numRows2));
            Print(Generate2(numRows2));
        }

        public static IList<IList<int>> Generate1(int numRows)
        {
            IList<IList<int>> triangle = new List<IList<int>>(numRows);

            for (int i = 0; i < numRows; i++)
            {
                int elementsInRow = i + 1;
                triangle.Add(new List<int>(elementsInRow));

                triangle[i].Add(1);

                for (int j = 1; j < elementsInRow - 1; j++)
                {
                    triangle[i].Add(triangle[i - 1][j - 1] + triangle[i - 1][j]);
                }

                if (elementsInRow > 1)
                {
                    triangle[i].Add(1);
                }
            }

            return triangle;
        }

        public static IList<IList<int>> Generate2(int numRows)
        {
            int[][] triangle = new int[numRows][];

            for (int i = 0; i < numRows; i++)
            {
                int elementsInRow = i + 1;
                triangle[i] = new int[elementsInRow];

                triangle[i][0] = 1;

                for (int j = 1; j < elementsInRow - 1; j++)
                {
                    triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
                }

                if (elementsInRow > 1)
                {
                    triangle[i][elementsInRow - 1] = 1;
                }
            }

            return triangle;
        }

        private static void Print(IList<IList<int>> list)
        {
            foreach (var row in list)
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
