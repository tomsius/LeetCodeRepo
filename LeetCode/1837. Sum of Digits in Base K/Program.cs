using System;
using System.Text;

namespace _1837._Sum_of_Digits_in_Base_K
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 34;
            int k1 = 6;
            Console.WriteLine(SumBase1(n1, k1));
            Console.WriteLine(SumBase2(n1, k1));

            int n2 = 10;
            int k2 = 10;
            Console.WriteLine(SumBase1(n2, k2));
            Console.WriteLine(SumBase2(n2, k2));

            int n3 = 68;
            int k3 = 2;
            Console.WriteLine(SumBase1(n3, k3));
            Console.WriteLine(SumBase2(n3, k3));

            int n4 = 29;
            int k4 = 2;
            Console.WriteLine(SumBase1(n4, k4));
            Console.WriteLine(SumBase2(n4, k4));
        }

        public static int SumBase1(int n, int k)
        {
            int sumOfDigits = 0;
            StringBuilder sb = new StringBuilder();

            //Forms reverse order
            while (n > 0)
            {
                sb.Append(n % k);
                n /= k;
            }

            for (int i = 0; i < sb.Length; i++)
            {
                sumOfDigits += int.Parse(sb[i].ToString());
            }

            return sumOfDigits;
        }

        public static int SumBase2(int n, int k)
        {
            int sumOfDigits = 0;

            while (n > 0)
            {
                sumOfDigits += (n % k);
                n /= k;
            }

            return sumOfDigits;
        }
    }
}
