using System;

namespace _1725._Number_Of_Rectangles_That_Can_Form_The_Largest_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] rectangles1 = new int[][] 
            { 
                new int[] { 5, 8 },
                new int[] { 3, 9 },
                new int[] { 5, 12 },
                new int[] { 16, 5 }
            };
            Console.WriteLine(CountGoodRectangles1(rectangles1));
            Console.WriteLine(CountGoodRectangles2(rectangles1));

            int[][] rectangles2 = new int[][]
            {
                new int[] { 2, 3 },
                new int[] { 3, 7 },
                new int[] { 4, 3 },
                new int[] { 3, 7 }
            };
            Console.WriteLine(CountGoodRectangles1(rectangles2));
            Console.WriteLine(CountGoodRectangles2(rectangles2));
        }

        public static int CountGoodRectangles1(int[][] rectangles)
        {
            int goodRectanglesCount = 0;
            int maxLen = GetMaxLen1(rectangles);

            foreach (var rectangle in rectangles)
            {
                if ((rectangle[0] == maxLen && maxLen <= rectangle[1]) || (rectangle[1] == maxLen && maxLen <= rectangle[0]))
                {
                    goodRectanglesCount++;
                }
            }

            return goodRectanglesCount;
        }

        private static int GetMaxLen1(int[][] rectangles)
        {
            int maxLen = 0;

            foreach (var rectangle in rectangles)
            {
                int smallerSide = rectangle[0] < rectangle[1] ? rectangle[0] : rectangle[1];

                if (smallerSide > maxLen)
                {
                    maxLen = smallerSide;
                }
            }

            return maxLen;
        }

        public static int CountGoodRectangles2(int[][] rectangles)
        {
            int goodRectanglesCount = 0;
            int maxLen = GetMaxLen2(rectangles);

            foreach (var rectangle in rectangles)
            {
                if ((rectangle[0] == maxLen && maxLen <= rectangle[1]) || (rectangle[1] == maxLen && maxLen <= rectangle[0]))
                {
                    goodRectanglesCount++;
                }
            }

            return goodRectanglesCount;
        }

        private static int GetMaxLen2(int[][] rectangles)
        {
            int maxLen = 0;

            foreach (var rectangle in rectangles)
            {
                int smallerSide = Math.Min(rectangle[0], rectangle[1]);
                maxLen = Math.Max(maxLen, smallerSide);
            }

            return maxLen;
        }
    }
}
