using System;

namespace _1266._Minimum_Time_Visiting_All_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] points1 = new int[][]
            {
                new int[] { 1, 1 },
                new int[] { 3, 4 },
                new int[] { -1, 0 }
            };
            Console.WriteLine(MinTimeToVisitAllPoints1(points1));
            points1 = new int[][]
            {
                new int[] { 1, 1 },
                new int[] { 3, 4 },
                new int[] { -1, 0 }
            };
            Console.WriteLine(MinTimeToVisitAllPoints2(points1));

            int[][] points2 = new int[][]
            {
                new int[] { 3, 2 },
                new int[] { -2, 2 }
            };
            Console.WriteLine(MinTimeToVisitAllPoints1(points2));
            points2 = new int[][]
            {
                new int[] { 3, 2 },
                new int[] { -2, 2 }
            };
            Console.WriteLine(MinTimeToVisitAllPoints2(points2));
        }

        public static int MinTimeToVisitAllPoints1(int[][] points)
        {
            int totalTime = 0;

            for (int i = 0; i < points.Length - 1; i++)
            {
                totalTime += GetTimeBetweenPoints1(points[i], points[i + 1]);
            }

            return totalTime;
        }

        private static int GetTimeBetweenPoints1(int[] pointA, int[] pointB)
        {
            int time = 0;

            while (pointA[0] != pointB[0] || pointA[1] != pointB[1])
            {
                if (pointA[0] == pointB[0])
                {
                    if (pointA[1] > pointB[1])
                    {
                        pointA[1]--;
                    }
                    else
                    {
                        pointA[1]++;
                    }
                }
                else if (pointA[1] == pointB[1])
                {
                    if (pointA[0] > pointB[0])
                    {
                        pointA[0]--;
                    }
                    else
                    {
                        pointA[0]++;
                    }
                }
                else
                {
                    if (pointA[0] > pointB[0] && pointA[1] > pointB[1])
                    {
                        pointA[0]--;
                        pointA[1]--;
                    }
                    else if (pointA[0] > pointB[0] && pointA[1] < pointB[1])
                    {
                        pointA[0]--;
                        pointA[1]++;
                    }
                    else if (pointA[0] < pointB[0] && pointA[1] < pointB[1])
                    {
                        pointA[0]++;
                        pointA[1]++;
                    }
                    else
                    {
                        pointA[0]++;
                        pointA[1]--;
                    }
                }

                time++;
            }

            return time;
        }

        public static int MinTimeToVisitAllPoints2(int[][] points)
        {
            int totalTime = 0;

            for (int i = 0; i < points.Length - 1; i++)
            {
                totalTime += Math.Max(Math.Abs(points[i + 1][0] - points[i][0]), Math.Abs(points[i + 1][1] - points[i][1]));
            }

            return totalTime;
        }
    }
}
