using System;
using System.Linq;

namespace _1317._Convert_Integer_to_the_Sum_of_Two_No_Zero_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 2;
            Console.WriteLine(String.Join(", ", GetNoZeroIntegers(n1)));

            int n2 = 11;
            Console.WriteLine(String.Join(", ", GetNoZeroIntegers(n2)));

            int n3 = 10000;
            Console.WriteLine(String.Join(", ", GetNoZeroIntegers(n3)));

            int n4 = 69;
            Console.WriteLine(String.Join(", ", GetNoZeroIntegers(n4)));

            int n5 = 1010;
            Console.WriteLine(String.Join(", ", GetNoZeroIntegers(n5)));
        }

        public static int[] GetNoZeroIntegers(int n)
        {
            int[] nonZeroIntegers = new int[2];

            for (int i = 1; i <= n / 2; i++)
            {
                int firstInteger = i;
                int secondInteger = n - i;

                if (IsNonZeroInteger(firstInteger) && IsNonZeroInteger(secondInteger))
                {
                    nonZeroIntegers[0] = firstInteger;
                    nonZeroIntegers[1] = secondInteger;
                    break;
                }
            }

            return nonZeroIntegers;
        }

        private static bool IsNonZeroInteger(int integer)
        {
            while (integer > 0)
            {
                if (integer % 10 == 0)
                {
                    return false;
                }

                integer /= 10;
            }

            return true;
        }
    }
}
