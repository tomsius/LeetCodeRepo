using System;
using System.Text;

namespace _1880._Check_if_Word_Equals_Summation_of_Two_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord1 = "acb";
            string secondWord1 = "cba";
            string targetWord1 = "cdb";
            Console.WriteLine(IsSumEqual(firstWord1, secondWord1, targetWord1));

            string firstWord2 = "aaa";
            string secondWord2 = "a";
            string targetWord2 = "aab";
            Console.WriteLine(IsSumEqual(firstWord2, secondWord2, targetWord2));

            string firstWord3 = "aaa";
            string secondWord3 = "a";
            string targetWord3 = "aaaa";
            Console.WriteLine(IsSumEqual(firstWord3, secondWord3, targetWord3));
        }

        public static bool IsSumEqual(string firstWord, string secondWord, string targetWord)
        {
            int firstWordValue = GetWordValue(firstWord);
            int secondWordValue = GetWordValue(secondWord);
            int targetWordValue = GetWordValue(targetWord);

            return firstWordValue + secondWordValue == targetWordValue;
        }

        private static int GetWordValue(string word)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var letter in word)
            {
                sb.Append(letter - 'a');
            }

            return int.Parse(sb.ToString());
        }
    }
}
