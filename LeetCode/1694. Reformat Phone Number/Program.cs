using System;
using System.Collections.Generic;
using System.Text;

namespace _1694._Reformat_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string number1 = "1-23-45 6";
            Console.WriteLine(ReformatNumber(number1));

            string number2 = "123 4-567";
            Console.WriteLine(ReformatNumber(number2));

            string number3 = "123 4-5678";
            Console.WriteLine(ReformatNumber(number3));

            string number4 = "12";
            Console.WriteLine(ReformatNumber(number4));

            string number5 = "--17-5 229 35-39475 ";
            Console.WriteLine(ReformatNumber(number5));
        }

        public static string ReformatNumber(string number)
        {
            StringBuilder sb = new StringBuilder();
            Queue<char> digits = new Queue<char>();

            foreach (var character in number)
            {
                if (char.IsDigit(character))
                {
                    digits.Enqueue(character);
                }
            }

            while (digits.Count > 0)
            {
                if (digits.Count == 4)
                {
                    sb.Append(digits.Dequeue());
                    sb.Append(digits.Dequeue());
                    sb.Append("-");
                    sb.Append(digits.Dequeue());
                    sb.Append(digits.Dequeue());
                }
                else if (digits.Count == 2)
                {
                    sb.Append(digits.Dequeue());
                    sb.Append(digits.Dequeue());
                }
                else
                {
                    sb.Append(digits.Dequeue());
                    sb.Append(digits.Dequeue());
                    sb.Append(digits.Dequeue());

                    if (digits.Count != 0)
                    {
                        sb.Append("-");
                    }
                }
            }

            return sb.ToString();
        }
    }
}
