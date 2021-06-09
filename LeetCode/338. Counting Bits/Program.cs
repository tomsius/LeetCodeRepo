using System;

namespace _338._Counting_Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 2;
            Console.WriteLine(String.Join(", ", CountBits1(n1)));
            Console.WriteLine(String.Join(", ", CountBits2(n1)));

            int n2 = 5;
            Console.WriteLine(String.Join(", ", CountBits1(n2)));
            Console.WriteLine(String.Join(", ", CountBits2(n2)));

            int n3 = 10;
            Console.WriteLine(String.Join(", ", CountBits1(n3)));
            Console.WriteLine(String.Join(", ", CountBits2(n3)));
        }

        public static int[] CountBits1(int n)
        {
            int[] ans = new int[n + 1];

            for (int i = 0; i <= n; i++)
            {
                ans[i] = CountOnes(Convert.ToString(i, 2));
            }

            return ans;
        }

        private static int CountOnes(string number)
        {
            int ones = 0;

            foreach (var digit in number)
            {
                if (digit == '1')
                {
                    ones++;
                }
            }

            return ones;
        }

        public static int[] CountBits2(int n)
        {
            int[] ans = new int[n + 1];

            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    ans[i] = ans[i / 2];
                }
                else
                {
                    ans[i] = ans[i / 2] + 1;
                }
            }

            return ans;
        }
    }
}
