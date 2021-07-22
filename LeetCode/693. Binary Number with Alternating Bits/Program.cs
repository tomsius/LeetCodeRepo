using System;

namespace _693._Binary_Number_with_Alternating_Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 5;
            Console.WriteLine(HasAlternatingBits(n1));

            int n2 = 7;
            Console.WriteLine(HasAlternatingBits(n2));

            int n3 = 11;
            Console.WriteLine(HasAlternatingBits(n3));

            int n4 = 10;
            Console.WriteLine(HasAlternatingBits(n4));

            int n5 = 3;
            Console.WriteLine(HasAlternatingBits(n5));
        }

        public static bool HasAlternatingBits(int n)
        {
            int lastDigit = n % 2;
            n /= 2;

            while (n > 0)
            {
                if (n % 2 == lastDigit)
                {
                    return false;
                }

                lastDigit = n % 2;

                n /= 2;
            }

            return true;
        }
    }
}
