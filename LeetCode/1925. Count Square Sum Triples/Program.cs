using System;

namespace _1925._Count_Square_Sum_Triples
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 5;
            Console.WriteLine(CountTriples1(n1));
            Console.WriteLine(CountTriples2(n1));

            int n2 = 10;
            Console.WriteLine(CountTriples1(n2));
            Console.WriteLine(CountTriples2(n2));

            int n3 = 12;
            Console.WriteLine(CountTriples1(n3));
            Console.WriteLine(CountTriples2(n3));
        }

        public static int CountTriples1(int n)
        {
            int squareTriplesCount = 0;

            for (int a = 1; a <= n; a++)
            {
                for (int b = 1; b <= n; b++)
                {
                    double pairSquareSumRoot = Math.Sqrt(a * a + b * b);
                    if (pairSquareSumRoot <= n && pairSquareSumRoot % 1 == 0)
                    {
                        squareTriplesCount++;
                    }
                }
            }

            return squareTriplesCount;
        }

        public static int CountTriples2(int n)
        {
            int squareTriplesCount = 0;

            for (int a = 1; a <= n; a++)
            {
                for (int b = 1; b <= n; b++)
                {
                    int c = (int)Math.Sqrt(a * a + b * b);
                    if (a * a + b * b == c * c && c <= n)
                    {
                        squareTriplesCount++;
                    }
                }
            }

            return squareTriplesCount;
        }
    }
}
