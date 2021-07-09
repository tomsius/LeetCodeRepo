using System;

namespace _762._Prime_Number_of_Set_Bits_in_Binary_Representation
{
    class Program
    {
        static void Main(string[] args)
        {
            int left1 = 6;
            int right1 = 10;
            Console.WriteLine(CountPrimeSetBits1(left1, right1));
            Console.WriteLine(CountPrimeSetBits2(left1, right1));

            int left2 = 10;
            int right2 = 15;
            Console.WriteLine(CountPrimeSetBits1(left2, right2));
            Console.WriteLine(CountPrimeSetBits2(left2, right2));
        }

        public static int CountPrimeSetBits1(int left, int right)
        {
            int count = 0;

            for (int number = left; number <= right; number++)
            {
                string binaryNumber = Convert.ToString(number, 2);
                int setBits = GetSetBitsCount1(binaryNumber);

                if (IsPrimeNumber1(setBits))
                {
                    count++;
                }
            }

            return count;
        }

        private static int GetSetBitsCount1(string binaryNumber)
        {
            int setBits = 0;

            foreach (var digit in binaryNumber)
            {
                if (digit == '1')
                {
                    setBits++;
                }
            }

            return setBits;
        }

        private static bool IsPrimeNumber1(int setBits)
        {
            if (setBits == 1)
            {
                return false;
            }

            for (int i = 2; i * i <= setBits; i++)
            {
                if (setBits % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static int CountPrimeSetBits2(int left, int right)
        {
            bool[] primes = { false, false, true, true, false, true, false, true, false, false, false, true, false, true, false, false, false, true, false, true, false };
            int count = 0;

            for (int number = left; number <= right; number++)
            {
                int setBits = GetSetBitsCount2(number);

                if (primes[setBits])
                {
                    count++;
                }
            }

            return count;
        }

        private static int GetSetBitsCount2(int number)
        {
            int setBits = 0;

            while (number > 0)
            {
                if (number % 2 == 1)
                {
                    setBits++;
                }

                number /= 2;
            }

            return setBits;
        }
    }
}
