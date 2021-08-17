using System;
using System.Collections.Generic;
using System.Linq;

namespace _733._Flood_Fill
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] image1 = new int[][]
            {
                new int[] { 1, 1, 1 },
                new int[] { 1, 1, 0 },
                new int[] { 1, 0, 1 }
            };
            int sr1 = 1;
            int sc1 = 1;
            int newColour1 = 2;
            Print(FloodFill1(image1, sr1, sc1, newColour1));
            image1 = new int[][]
            {
                new int[] { 1, 1, 1 },
                new int[] { 1, 1, 0 },
                new int[] { 1, 0, 1 }
            };
            Print(FloodFill2(image1, sr1, sc1, newColour1));
            image1 = new int[][]
            {
                new int[] { 1, 1, 1 },
                new int[] { 1, 1, 0 },
                new int[] { 1, 0, 1 }
            };
            Print(FloodFill3(image1, sr1, sc1, newColour1));

            int[][] image2 = new int[][]
            {
                new int[] { 0, 0, 0 },
                new int[] { 0, 0, 0 }
            };
            int sr2 = 0;
            int sc2 = 0;
            int newColour2 = 2;
            Print(FloodFill1(image2, sr2, sc2, newColour2));
            image2 = new int[][]
            {
                new int[] { 0, 0, 0 },
                new int[] { 0, 0, 0 }
            };
            Print(FloodFill2(image2, sr2, sc2, newColour2));
            image2 = new int[][]
            {
                new int[] { 0, 0, 0 },
                new int[] { 0, 0, 0 }
            };
            Print(FloodFill3(image2, sr2, sc2, newColour2));

            int[][] image3 = new int[][]
            {
                new int[] { 0, 0, 0 },
                new int[] { 0, 1, 1 }
            };
            int sr3 = 1;
            int sc3 = 1;
            int newColour3 = 1;
            Print(FloodFill1(image3, sr3, sc3, newColour3));
            image3 = new int[][]
            {
                new int[] { 0, 0, 0 },
                new int[] { 0, 1, 1 }
            };
            Print(FloodFill2(image3, sr3, sc3, newColour3));
            image3 = new int[][]
            {
                new int[] { 0, 0, 0 },
                new int[] { 0, 1, 1 }
            };
            Print(FloodFill3(image3, sr3, sc3, newColour3));
        }

        private static void Print(int[][] image)
        {
            foreach (var row in image)
            {
                foreach (var col in row)
                {
                    Console.Write(col + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public static int[][] FloodFill1(int[][] image, int sr, int sc, int newColor)
        {
            FloodFill(image, sr, sc, image[sr][sc], newColor);

            return image;
        }

        private static void FloodFill(int[][] image, int sr, int sc, int oldColor, int newColor)
        {
            image[sr][sc] = newColor;

            if (sr - 1 >= 0 && image[sr - 1][sc] == oldColor && image[sr - 1][sc] != newColor)
            {
                FloodFill(image, sr - 1, sc, oldColor, newColor);
            }

            if (sr + 1 < image.Length && image[sr + 1][sc] == oldColor && image[sr + 1][sc] != newColor)
            {
                FloodFill(image, sr + 1, sc, oldColor, newColor);
            }

            if (sc - 1 >= 0 && image[sr][sc - 1] == oldColor && image[sr][sc - 1] != newColor)
            {
                FloodFill(image, sr, sc - 1, oldColor, newColor);
            }

            if (sc + 1 < image[0].Length && image[sr][sc + 1] == oldColor && image[sr][sc + 1] != newColor)
            {
                FloodFill(image, sr, sc + 1, oldColor, newColor);
            }
        }

        public static int[][] FloodFill2(int[][] image, int sr, int sc, int newColor)
        {
            if (image[sr][sc] != newColor)
            {
                DFS(image, sr, sc, image[sr][sc], newColor);
            }

            return image;
        }

        private static void DFS(int[][] image, int row, int col, int oldColor, int newColor)
        {
            if (image[row][col] == oldColor)
            {
                image[row][col] = newColor;

                if (row - 1 >= 0)
                {
                    DFS(image, row - 1, col, oldColor, newColor);
                }

                if (col - 1 >= 0)
                {
                    DFS(image, row, col - 1, oldColor, newColor);
                }

                if (row + 1 < image.Length)
                {
                    DFS(image, row + 1, col, oldColor, newColor);
                }

                if (col + 1 < image[0].Length)
                {
                    DFS(image, row, col + 1, oldColor, newColor);
                }
            }
        }

        public static int[][] FloodFill3(int[][] image, int sr, int sc, int newColor)
        {
            if (image[sr][sc] == newColor)
            {
                return image;
            }

            Stack<(int, int)> stack = new Stack<(int, int)>();
            int oldColour = image[sr][sc];
            stack.Push((sr, sc));

            while (stack.Count > 0)
            {
                (int row, int col) position = stack.Pop();

                if (image[position.row][position.col] == oldColour)
                {
                    image[position.row][position.col] = newColor;

                    if (position.row - 1 >= 0)
                    {
                        stack.Push((position.row - 1, position.col));
                    }

                    if (position.col - 1 >= 0)
                    {
                        stack.Push((position.row, position.col - 1));
                    }

                    if (position.row + 1 < image.Length)
                    {
                        stack.Push((position.row + 1, position.col));
                    }

                    if (position.col + 1 < image[0].Length)
                    {
                        stack.Push((position.row, position.col + 1));
                    }
                }
            }

            return image;
        }
    }
}
