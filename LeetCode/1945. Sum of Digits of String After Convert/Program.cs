using System;
using System.Text;

namespace _1945._Sum_of_Digits_of_String_After_Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "iiii";
            int k1 = 1;
            Console.WriteLine(GetLucky(s1, k1));

            string s2 = "leetcode";
            int k2 = 2;
            Console.WriteLine(GetLucky(s2, k2));

            string s3 = "zbax";
            int k3 = 2;
            Console.WriteLine(GetLucky(s3, k3));
        }

        public static int GetLucky(string s, int k)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var letter in s)
            {
                string digit = (letter - 'a' + 1).ToString();
                sb.Append(digit);
            }

            string result = sb.ToString();

            for (int i = 0; i < k; i++)
            {
                result = GetSumOfDigits(result);
            }

            return int.Parse(result);
        }

        private static string GetSumOfDigits(string number)
        {
            int sumOfDigits = 0;

            foreach (var digit in number)
            {
                sumOfDigits += int.Parse(digit.ToString());
            }

            return sumOfDigits.ToString();
        }
    }
}
