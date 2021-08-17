using System;

namespace _191._Number_of_1_Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n1 = 00000000000000000000000000001011;
            Console.WriteLine(HammingWeight(n1));

            uint n2 = 00000000000000000000000010000000;
            Console.WriteLine(HammingWeight(n2));
        }

        public static int HammingWeight(uint n)
        {
            int totalOnes = 0;

            while (n != 0)
            {
                totalOnes += (int)n & 1;
                n = n >> 1;
            }

            return totalOnes;
        }
    }
}
