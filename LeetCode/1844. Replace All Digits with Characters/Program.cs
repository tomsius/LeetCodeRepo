using System;
using System.Text;

namespace _1844._Replace_All_Digits_with_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = "a1c1e1";
            Console.WriteLine(ReplaceDigits1(input1));
            Console.WriteLine(ReplaceDigits2(input1));

            string input2 = "a1b2c3d4e";
            Console.WriteLine(ReplaceDigits1(input2));
            Console.WriteLine(ReplaceDigits2(input2));
        }

        public static string ReplaceDigits1(string s)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sb.Append(s[i]);
                }
                else
                {
                    sb.Append((char)(s[i - 1] + int.Parse(s[i].ToString())));
                }
            }

            return sb.ToString();
        }

        public static string ReplaceDigits2(string s)
        {
            char[] output = s.ToCharArray();

            for (int i = 1; i < output.Length; i += 2)
            {
                output[i] = (char)((int)output[i - 1] + int.Parse(output[i].ToString()));
            }

            return new string(output);
        }
    }
}
