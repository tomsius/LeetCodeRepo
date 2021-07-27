using System;

namespace _812._Largest_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] points1 = new int[][]
            {
                new int[] { 0, 0 },
                new int[] { 0, 1 },
                new int[] { 1, 0 },
                new int[] { 0, 2 },
                new int[] { 2, 0 }
            };
            Console.WriteLine(LargestTriangleArea(points1));

            int[][] points2 = new int[][]
            {
                new int[] { 1, 0 },
                new int[] { 0, 0 },
                new int[] { 0, 1 }
            };
            Console.WriteLine(LargestTriangleArea(points2));

            int[][] points3 = new int[][]
            {
                new int[] { 4, 6 },
                new int[] { 6, 5 },
                new int[] { 3, 1 }
            };
            Console.WriteLine(LargestTriangleArea(points3));

            int[][] points4 = new int[][]
            {
                new int[] { -35, 19 },
                new int[] { 40, 19 },
                new int[] { 27, -20 },
                new int[] { 35, -3 },
                new int[] { 44, 20 },
                new int[] { 22, -21 },
                new int[] { 35, 33 },
                new int[] { -19, 42 },
                new int[] { 11, 47 },
                new int[] { 11, 37 },
            };
            Console.WriteLine(LargestTriangleArea(points4));
        }

        public static double LargestTriangleArea(int[][] points)
        {
            double maximumArea = 0;

            for (int i = 0; i < points.Length - 2; i++)
            {
                for (int j = i + 1; j < points.Length - 1; j++)
                {
                    for (int k = j + 1; k < points.Length; k++)
                    {
                        double a = Math.Sqrt(Math.Pow(points[j][0] - points[i][0], 2) + Math.Pow(points[j][1] - points[i][1], 2));
                        double b = Math.Sqrt(Math.Pow(points[j][0] - points[k][0], 2) + Math.Pow(points[j][1] - points[k][1], 2));
                        double c = Math.Sqrt(Math.Pow(points[k][0] - points[i][0], 2) + Math.Pow(points[k][1] - points[i][1], 2));

                        double area = CalculateArea(a, b, c);

                        maximumArea = Math.Max(maximumArea, area);
                    }
                }
            }

            return maximumArea;
        }

        private static double CalculateArea(double a, double b, double c)
        {
            double semiPerimeter = (a + b + c) / 2;
            double area = Math.Sqrt(semiPerimeter * Math.Round(semiPerimeter - a, 7) * Math.Round(semiPerimeter - b, 7) * Math.Round(semiPerimeter - c, 7));

            return Math.Round(area, 5);
        }
    }
}
