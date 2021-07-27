using System;

namespace _258._Add_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 38;
            Console.WriteLine(AddDigits1(num1));
            Console.WriteLine(AddDigits2(num1));
            Console.WriteLine(AddDigits3(num1));
            Console.WriteLine(AddDigits4(num1));

            int num2 = 0;
            Console.WriteLine(AddDigits1(num2));
            Console.WriteLine(AddDigits2(num2));
            Console.WriteLine(AddDigits3(num2));
            Console.WriteLine(AddDigits4(num2));

            int num3 = 18;
            Console.WriteLine(AddDigits1(num3));
            Console.WriteLine(AddDigits2(num3));
            Console.WriteLine(AddDigits3(num3));
            Console.WriteLine(AddDigits4(num3));
        }

        public static int AddDigits1(int num)
        {
            while (num.ToString().Length > 1)
            {
                int newNum = 0;

                while (num > 0)
                {
                    newNum += num % 10;
                    num /= 10;
                }

                num = newNum;
            }

            return num;
        }

        public static int AddDigits2(int num)
        {
            int digitalRoot = 0;

            while (num > 0)
            {
                digitalRoot += num % 10;
                num /= 10;

                if (num == 0 && digitalRoot > 9)
                {
                    num = digitalRoot;
                    digitalRoot = 0;
                }
            }

            return digitalRoot;
        }

        public static int AddDigits3(int num)
        {
            if (num == 0)
            {
                return 0;
            }
            else if (num % 9 == 0)
            {
                return 9;
            }
            else
            {
                return num % 9;
            }
        }

        public static int AddDigits4(int num)
        {
            if (num == 0)
            {
                return 0;
            }
            else
            {
                return 1 + (num - 1) % 9;
            }
        }
    }
}
