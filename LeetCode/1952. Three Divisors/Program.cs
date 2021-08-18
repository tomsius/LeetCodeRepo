using System;

namespace _1952._Three_Divisors
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 2;
            Console.WriteLine(IsThree(n1));

            int n2 = 4;
            Console.WriteLine(IsThree(n2));

            int n3 = 1;
            Console.WriteLine(IsThree(n3));
        }

        public static bool IsThree(int n)
        {
            int totalDivisors = 0;

            for (int i = 1; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    totalDivisors += 2;

                    if (n / i == i)
                    {
                        totalDivisors--;
                    }
                }
            }

            return totalDivisors == 3;
        }
    }
}
