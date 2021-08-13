using System;
using System.Text;

namespace _1556._Thousand_Separator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 987;
            Console.WriteLine(ThousandSeparator(n1));

            int n2 = 1234;
            Console.WriteLine(ThousandSeparator(n2));

            int n3 = 123456789;
            Console.WriteLine(ThousandSeparator(n3));

            int n4 = 0;
            Console.WriteLine(ThousandSeparator(n4));
        }

        public static string ThousandSeparator(int n)
        {
            string number = n.ToString();
            StringBuilder sb = new StringBuilder();
            int offset = number.Length % 3;
            int index = 0;

            while (index < offset)
            {
                sb.Append(number[index]);
                index++;
            }

            if (offset != 0 && number.Length > 3)
            {
                sb.Append('.'); 
            }

            while (index < number.Length)
            {
                sb.Append(number[index]);
                sb.Append(number[index + 1]);
                sb.Append(number[index + 2]);

                if (index + 3 != number.Length)
                {
                    sb.Append('.'); 
                }

                index += 3;
            }

            return sb.ToString();
        }
    }
}
