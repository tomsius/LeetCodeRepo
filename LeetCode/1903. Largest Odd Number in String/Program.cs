using System;

namespace _1903._Largest_Odd_Number_in_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = "52";
            Console.WriteLine(LargestOddNumber1(num1));
            Console.WriteLine(LargestOddNumber2(num1));

            string num2 = "4206";
            Console.WriteLine(LargestOddNumber1(num2));
            Console.WriteLine(LargestOddNumber2(num2));

            string num3 = "35427";
            Console.WriteLine(LargestOddNumber1(num3));
            Console.WriteLine(LargestOddNumber2(num3));
        }

        public static string LargestOddNumber1(string num)
        {
            int length = 0;

            for (int i = num.Length - 1; i >= 0; i--)
            {
                if (int.Parse(num[i].ToString()) % 2 == 1)
                {
                    length = i + 1;
                    break;
                }
            }

            return num.Substring(0, length);
        }

        public static string LargestOddNumber2(string num)
        {
            int length = num.Length - 1;

            while (length >= 0 && (num[length] - '0') % 2 == 0)
            {
                length--;
            }

            return num.Substring(0, length + 1);
        }
    }
}
