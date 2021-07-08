using System;

namespace _1025._Divisor_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 2;
            Console.WriteLine(DivisorGame1(n1));
            Console.WriteLine(DivisorGame2(n1));
            Console.WriteLine(DivisorGame3(n1));

            int n2 = 3;
            Console.WriteLine(DivisorGame1(n2));
            Console.WriteLine(DivisorGame2(n2));
            Console.WriteLine(DivisorGame3(n2));
        }

        public static bool DivisorGame1(int n)
        {
            return DivisorGameRec1(n);
        }

        private static bool DivisorGameRec1(int n)
        {
            if (n == 1)
            {
                return false;
            }
            else
            {
                for (int i = 1; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        if (DivisorGameRec1(n - i) == false)
                        {
                            return true;
                        }
                    }
                }

                return false;
            }
        }

        public static bool DivisorGame2(int n)
        {
            int[] dp = new int[n + 1];
            Array.Fill(dp, -1);

            return DivisorGameRec2(n, dp) == 1;
        }

        private static int DivisorGameRec2(int n, int[] dp)
        {
            if (n == 1)
            {
                return 0;
            }
            if (dp[n] != -1)
            {
                return dp[n];
            }
            else
            {
                for (int i = 1; i * i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        if (DivisorGameRec2(n - i, dp) == 0)
                        {
                            dp[n] = 1;
                            return 1;
                        }

                        if (i != 1  && DivisorGameRec2(n - (n / i), dp) == 0)
                        {
                            dp[n] = 1;
                            return 1;
                        }
                    }
                }

                dp[n] = 0;
                return 0;
            }
        }

        public static bool DivisorGame3(int n)
        {
            return n % 2 == 0;
        }
    }
}
