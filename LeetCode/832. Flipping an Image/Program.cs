using System;

namespace _832._Flipping_an_Image
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] image1 = new int[][]
            {
                new int[] { 1, 1, 0 },
                new int[] { 1, 0, 1 },
                new int[] { 0, 0, 0 }
            };
            Print(FlipAndInvertImage1(image1));
            Console.WriteLine();
            image1 = new int[][]
            {
                new int[] { 1, 1, 0 },
                new int[] { 1, 0, 1 },
                new int[] { 0, 0, 0 }
            };
            Print(FlipAndInvertImage2(image1));
            Console.WriteLine();

            int[][] image2 = new int[][]
            {
                new int[] { 1, 1, 0, 0 },
                new int[] { 1, 0, 0, 1 },
                new int[] { 0, 1, 1, 1 },
                new int[] { 1, 0, 1, 0 }
            };
            Print(FlipAndInvertImage1(image2));
            Console.WriteLine();
            image2 = new int[][]
            {
                new int[] { 1, 1, 0, 0 },
                new int[] { 1, 0, 0, 1 },
                new int[] { 0, 1, 1, 1 },
                new int[] { 1, 0, 1, 0 }
            };
            Print(FlipAndInvertImage2(image2));
        }

        private static void Print(int[][] image)
        {
            foreach (var row in image)
            {
                foreach (var value in row)
                {
                    Console.Write(value + " ");
                }

                Console.Write("\n");
            }
        }

        public static int[][] FlipAndInvertImage1(int[][] image)
        {
            for (int row = 0; row < image.Length; row++)
            {
                for (int col = 0; col < image[row].Length / 2; col++)
                {
                    int temp = image[row][col];
                    image[row][col] = image[row][image[row].Length - col - 1];
                    image[row][image[row].Length - col - 1] = temp;
                }
            }

            for (int row = 0; row < image.Length; row++)
            {
                for (int col = 0; col < image[row].Length; col++)
                {
                    image[row][col] = image[row][col] == 1 ? 0 : 1;
                }
            }

            return image;
        }

        public static int[][] FlipAndInvertImage2(int[][] image)
        {
            for (int row = 0; row < image.Length; row++)
            {
                for (int col = 0; col < image[row].Length / 2; col++)
                {
                    int temp = image[row][col] == 1 ? 0 : 1;
                    image[row][col] = image[row][image[row].Length - col - 1] == 1 ? 0 : 1;
                    image[row][image[row].Length - col - 1] = temp;
                }

                if (image[row].Length % 2 == 1)
                {
                    image[row][image[row].Length / 2] = image[row][image[row].Length / 2] == 1 ? 0 : 1;
                }
            }

            return image;
        }
    }
}
