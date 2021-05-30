using System;

namespace _1304._Find_N_Unique_Integers_Sum_up_to_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 5;
            Console.WriteLine(string.Join(" ", SumZero1(n1)));
            Console.WriteLine(string.Join(" ", SumZero2(n1)));

            int n2 = 3;
            Console.WriteLine(string.Join(" ", SumZero1(n2)));
            Console.WriteLine(string.Join(" ", SumZero2(n2)));

            int n3 = 1;
            Console.WriteLine(string.Join(" ", SumZero1(n3)));
            Console.WriteLine(string.Join(" ", SumZero2(n3)));

            int n4 = 2;
            Console.WriteLine(string.Join(" ", SumZero1(n4)));
            Console.WriteLine(string.Join(" ", SumZero2(n4)));
        }

        public static int[] SumZero1(int n)
        {
            int[] digits = new int[n];
            int sum = 0;

            for (int i = 0; i < n - 1; i++)
            {
                digits[i] = i + 1;
                sum += i + 1;
            }

            digits[n - 1] = -sum;

            return digits;
        }

        public static int[] SumZero2(int n)
        {
            int[] digits = new int[n];

            if (n % 2 == 1)
            {
                digits[0] = 0;
            }

            for (int i = 1; i < n - 1; i+=2)
            {
                digits[i] = i + 1;
                digits[i + 1] = -(i + 1);
            }

            return digits;
        }
    }
}
