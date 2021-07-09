using System;
using System.Text;

namespace _476._Number_Complement
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            Console.WriteLine(FindComplement(num1));

            int num2 = 1;
            Console.WriteLine(FindComplement(num2));
        }

        public static int FindComplement(int num)
        {
            StringBuilder sb = new StringBuilder();
            string binaryNumber = Convert.ToString(num, 2);

            foreach (var digit in binaryNumber)
            {
                if (digit == '0')
                {
                    sb.Append('1');
                }
                else
                {
                    sb.Append('0');
                }
            }

            return Convert.ToInt32(sb.ToString(), 2);
        }
    }
}
