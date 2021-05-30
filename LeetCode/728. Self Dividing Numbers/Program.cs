using System;
using System.Collections.Generic;

namespace _728._Self_Dividing_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int left = 1;
            int right = 22;
            Console.WriteLine(string.Join(" ", SelfDividingNumbers1(left, right)));
            Console.WriteLine(string.Join(" ", SelfDividingNumbers2(left, right)));
        }

        public static IList<int> SelfDividingNumbers1(int left, int right)
        {
            List<int> numbers = new List<int>(right - left + 1);

            for (int number = left; number <= right; number++)
            {
                if (IsSelfDividing1(number))
                {
                    numbers.Add(number);
                }
            }

            return numbers;
        }

        private static bool IsSelfDividing1(int number)
        {
            string digits = number.ToString();

            foreach (var digit in digits)
            {
                if ((int.Parse(digit.ToString()) == 0) || (number % int.Parse(digit.ToString()) != 0))
                {
                    return false;
                }
            }

            return true;
        }

        public static IList<int> SelfDividingNumbers2(int left, int right)
        {
            List<int> numbers = new List<int>(right - left + 1);

            for (int number = left; number <= right; number++)
            {
                if (IsSelfDividing2(number))
                {
                    numbers.Add(number);
                }
            }

            return numbers;
        }

        private static bool IsSelfDividing2(int number)
        {
            int originalNumber = number;

            while (number > 0)
            {
                if (number % 10 == 0 || originalNumber % (number % 10) != 0)
                {
                    return false;
                }

                number = number / 10;
            }

            return true;
        }
    }
}
