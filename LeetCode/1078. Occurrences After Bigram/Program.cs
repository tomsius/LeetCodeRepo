using System;
using System.Collections.Generic;

namespace _1078._Occurrences_After_Bigram
{
    class Program
    {
        static void Main(string[] args)
        {
            string text1 = "alice is a good girl she is a good student";
            string first1 = "a";
            string second1 = "good";
            Console.WriteLine(String.Join(", ", FindOcurrences(text1, first1, second1)));

            string text2 = "we will we will rock you";
            string first2 = "we";
            string second2 = "will";
            Console.WriteLine(String.Join(", ", FindOcurrences(text2, first2, second2)));
        }

        public static string[] FindOcurrences(string text, string first, string second)
        {
            List<string> occurancesAfterBigram = new List<string>();
            string[] words = text.Split(' ');

            for (int i = 0; i < words.Length - 2; i++)
            {
                if (words[i] == first && words[i + 1] == second)
                {
                    occurancesAfterBigram.Add(words[i + 2]);
                }
            }

            return occurancesAfterBigram.ToArray();
        }
    }
}
