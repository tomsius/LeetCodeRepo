using System;

namespace _1779._Find_Nearest_Point_That_Has_the_Same_X_or_Y_Coordinate
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 3;
            int y1 = 4;
            int[][] points1 = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 3, 1 },
                new int[] { 2, 4 },
                new int[] { 2, 3 },
                new int[] { 4, 4 }
            };
            Console.WriteLine(NearestValidPoint(x1, y1, points1));

            int x2 = 3;
            int y2 = 4;
            int[][] points2 = new int[][]
            {
                new int[] { 3, 4 }
            };
            Console.WriteLine(NearestValidPoint(x2, y2, points2));

            int x3 = 3;
            int y3 = 4;
            int[][] points3 = new int[][]
            {
                new int[] { 2, 3 }
            };
            Console.WriteLine(NearestValidPoint(x3, y3, points3));
        }

        public static int NearestValidPoint(int x, int y, int[][] points)
        {
            int smallestManhattanDistance = int.MaxValue;
            int index = -1;

            for (int i = 0; i < points.Length; i++)
            {
                if (points[i][0] == x || points[i][1] == y)
                {
                    int manhattanDistance = GetManhattanDistance(x, y, points[i][0], points[i][1]);

                    if (manhattanDistance < smallestManhattanDistance)
                    {
                        smallestManhattanDistance = manhattanDistance;
                        index = i;
                    }
                }
            }

            return index;
        }

        private static int GetManhattanDistance(int x1, int y1, int x2, int y2)
        {
            return Math.Abs(x1 - x2) + Math.Abs(y1 - y2);
        }
    }
}
