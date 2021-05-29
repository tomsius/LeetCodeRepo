using System;
using System.Text;

namespace _1323._Maximum_69_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 9669;
            Console.WriteLine(Maximum69Number1(num1));
            Console.WriteLine(Maximum69Number2(num1));

            int num2 = 9996;
            Console.WriteLine(Maximum69Number1(num2));
            Console.WriteLine(Maximum69Number2(num2));

            int num3 = 9999;
            Console.WriteLine(Maximum69Number1(num3));
            Console.WriteLine(Maximum69Number2(num3));
        }

        public static int Maximum69Number1(int num)
        {
            char[] digits = num.ToString().ToCharArray();

            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] == '6')
                {
                    digits[i] = '9';
                    break;
                }
            }

            return int.Parse(new string(digits));
        }

        public static int Maximum69Number2(int num)
        {
            StringBuilder sb = new StringBuilder(num.ToString());

            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] == '6')
                {
                    sb[i] = '9';
                    break;
                }
            }

            return int.Parse(sb.ToString());
        }
    }
}
