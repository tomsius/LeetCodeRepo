using System;

namespace _1859._Sorting_the_Sentence
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "is2 sentence4 This1 a3";
            Console.WriteLine(SortSentence(s1));

            string s2 = "Myself2 Me1 I4 and3";
            Console.WriteLine(SortSentence(s2));
        }

        public static string SortSentence(string s)
        {
            string[] words = s.Split(" ");
            string[] sortedSentence = new string[words.Length];

            foreach (var word in words)
            {
                string actualWord = word.Substring(0, word.Length - 1);
                int index = int.Parse(word.Substring(word.Length - 1));

                sortedSentence[index - 1] = actualWord;
            }

            return string.Join(" ", sortedSentence);
        }
    }
}
