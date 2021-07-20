using System;
using System.Text;

namespace _1009._Complement_of_Base_10_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 5;
            Console.WriteLine(BitwiseComplement(n1));

            int n2 = 7;
            Console.WriteLine(BitwiseComplement(n2));

            int n3 = 10;
            Console.WriteLine(BitwiseComplement(n3));
        }

        public static int BitwiseComplement(int n)
        {
            StringBuilder sb = new StringBuilder();
            string binaryNumber = Convert.ToString(n, 2);

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
