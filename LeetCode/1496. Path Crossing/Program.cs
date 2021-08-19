using System;
using System.Collections.Generic;

namespace _1496._Path_Crossing
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = "NES";
            Console.WriteLine(IsPathCrossing1(path1));
            Console.WriteLine(IsPathCrossing2(path1));
            Console.WriteLine(IsPathCrossing3(path1));

            string path2 = "NESWW";
            Console.WriteLine(IsPathCrossing1(path2));
            Console.WriteLine(IsPathCrossing2(path2));
            Console.WriteLine(IsPathCrossing3(path2));
        }

        public static bool IsPathCrossing1(string path)
        {
            HashSet<Tuple<int, int>> visitedPoints = new HashSet<Tuple<int, int>>();
            Tuple<int, int> currentPoint = new Tuple<int, int>(0, 0);
            visitedPoints.Add(currentPoint);

            foreach (var direction in path)
            {
                switch (direction)
                {
                    case 'N':
                        currentPoint = new Tuple<int, int>(currentPoint.Item1, currentPoint.Item2 + 1);

                        if (!visitedPoints.Add(currentPoint))
                        {
                            return true;
                        }

                        break;
                    case 'E':
                        currentPoint = new Tuple<int, int>(currentPoint.Item1 + 1, currentPoint.Item2);

                        if (!visitedPoints.Add(currentPoint))
                        {
                            return true;
                        }

                        break;
                    case 'S':
                        currentPoint = new Tuple<int, int>(currentPoint.Item1, currentPoint.Item2 - 1);

                        if (!visitedPoints.Add(currentPoint))
                        {
                            return true;
                        }

                        break;
                    case 'W':
                        currentPoint = new Tuple<int, int>(currentPoint.Item1 - 1, currentPoint.Item2);

                        if (!visitedPoints.Add(currentPoint))
                        {
                            return true;
                        }

                        break;
                    default:
                        break;
                }
            }

            return false;
        }

        public static bool IsPathCrossing2(string path)
        {
            HashSet<(int, int)> visitedPoints = new HashSet<(int, int)>();
            (int x, int y) currentPoint = (0, 0);
            visitedPoints.Add(currentPoint);

            foreach (var direction in path)
            {
                switch (direction)
                {
                    case 'N':
                        currentPoint = (currentPoint.x, currentPoint.y + 1);

                        break;
                    case 'E':
                        currentPoint = (currentPoint.x + 1, currentPoint.y);

                        break;
                    case 'S':
                        currentPoint = (currentPoint.x, currentPoint.y - 1);

                        break;
                    case 'W':
                        currentPoint = (currentPoint.x - 1, currentPoint.y);

                        break;
                    default:
                        break;
                }

                if (!visitedPoints.Add(currentPoint))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool IsPathCrossing3(string path)
        {
            HashSet<int> visitedPoints = new HashSet<int>();
            int x = 0;
            int y = 0;

            visitedPoints.Add(GetHash(x, y));

            foreach (var direction in path)
            {
                switch (direction)
                {
                    case 'N':
                        y++;

                        break;
                    case 'E':
                        x++;

                        break;
                    case 'S':
                        y--;

                        break;
                    case 'W':
                        x--;

                        break;
                    default:
                        break;
                }

                if (!visitedPoints.Add(GetHash(x, y)))
                {
                    return true;
                }
            }

            return false;
        }

        private static int GetHash(int x, int y)
        {
            return x * 1000 + y;
        }
    }
}
