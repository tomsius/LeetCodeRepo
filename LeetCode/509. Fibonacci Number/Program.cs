using System;

namespace _509._Fibonacci_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 2;
            Console.WriteLine(Fib1(n1));
            Console.WriteLine(Fib2(n1));
            Console.WriteLine(Fib3(n1));
            Console.WriteLine(Fib4(n1));

            int n2 = 3;
            Console.WriteLine(Fib1(n2));
            Console.WriteLine(Fib2(n2));
            Console.WriteLine(Fib3(n2));
            Console.WriteLine(Fib4(n2));

            int n3 = 4;
            Console.WriteLine(Fib1(n3));
            Console.WriteLine(Fib2(n3));
            Console.WriteLine(Fib3(n3));
            Console.WriteLine(Fib4(n3));
        }

        public static int Fib1(int n)
        {
            if (n <= 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }

            return Fib1(n - 1) + Fib1(n - 2);
        }

        public static int Fib2(int n)
        {
            if (n <= 0)
            {
                return 0;
            }

            int[] fib = new int[n + 1];
            fib[0] = 0;
            fib[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }

            return fib[n];
        }

        public static int Fib3(int n)
        {
            if (n <= 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }

            int first = 0;
            int second = 1;
            int fib = first + second;

            for (int i = 2; i <= n; i++)
            {
                fib = first + second;
                first = second;
                second = fib;
            }

            return fib;
        }

        public static int Fib4(int n)
        {
            int[] fib = { 0, 1 };

            for (int i = 2; i <= n; i++)
            {
                fib[i % 2] = fib[0] + fib[1];
            }
            return fib[n % 2];
        }
    }
}
