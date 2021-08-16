using System;

namespace _1137._N_th_Tribonacci_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 4;
            Console.WriteLine(Tribonacci1(n1));
            Console.WriteLine(Tribonacci2(n1));
            Console.WriteLine(Tribonacci3(n1));

            int n2 = 25;
            Console.WriteLine(Tribonacci1(n2));
            Console.WriteLine(Tribonacci2(n2));
            Console.WriteLine(Tribonacci3(n2));
        }

        public static int Tribonacci1(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            if (n == 1 || n == 2)
            {
                return 1;
            }

            return Tribonacci1(n - 1) + Tribonacci1(n - 2) + Tribonacci1(n - 3);
        }

        public static int Tribonacci2(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            if (n == 1 || n == 2)
            {
                return 1;
            }

            int[] numbers = new int[n + 1];
            numbers[0] = 0;
            numbers[1] = 1;
            numbers[2] = 1;

            for (int i = 3; i <= n; i++)
            {
                numbers[i] = numbers[i - 3] + numbers[i - 2] + numbers[i - 1];
            }

            return numbers[n];
        }

        public static int Tribonacci3(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            if (n == 1 || n == 2)
            {
                return 1;
            }

            int first = 0;
            int second = 1;
            int third = 1;
            int current = 0;

            for (int i = 3; i <= n; i++)
            {
                current = first + second + third;
                first = second;
                second = third;
                third = current;
            }

            return current;
        }
    }
}
