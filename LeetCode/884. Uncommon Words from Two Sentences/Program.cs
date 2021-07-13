using System;
using System.Collections.Generic;

namespace _884._Uncommon_Words_from_Two_Sentences
{
    class Program
    {
        static void Main(string[] args)
        {
            string s11 = "this apple is sweet";
            string s21 = "this apple is sour";
            Console.WriteLine(String.Join(", ", UncommonFromSentences1(s11, s21)));
            Console.WriteLine(String.Join(", ", UncommonFromSentences2(s11, s21)));

            string s12 = "apple apple";
            string s22 = "banana";
            Console.WriteLine(String.Join(", ", UncommonFromSentences1(s12, s22)));
            Console.WriteLine(String.Join(", ", UncommonFromSentences2(s12, s22)));
        }

        public static string[] UncommonFromSentences1(string s1, string s2)
        {
            Dictionary<string, int> firstSentenceWords = GetSentenceWords(s1);
            Dictionary<string, int> secondSentenceWords = GetSentenceWords(s2);

            List<string> uncommonWords = GetUncommonWords(firstSentenceWords, secondSentenceWords);
            uncommonWords.AddRange(GetUncommonWords(secondSentenceWords, firstSentenceWords));

            return uncommonWords.ToArray();
        }

        private static Dictionary<string, int> GetSentenceWords(string s)
        {
            Dictionary<string, int> sentenceWords = new Dictionary<string, int>();
            string[] words = s.Split(' ');

            foreach (var word in words)
            {
                if (sentenceWords.ContainsKey(word))
                {
                    sentenceWords[word]++;
                }
                else
                {
                    sentenceWords.Add(word, 1);
                }
            }

            return sentenceWords;
        }

        private static List<string> GetUncommonWords(Dictionary<string, int> first, Dictionary<string, int> second)
        {
            List<string> uniqueWords = new List<string>();

            foreach (var kvp in first)
            {
                if (kvp.Value == 1 && !second.ContainsKey(kvp.Key))
                {
                    uniqueWords.Add(kvp.Key);
                }
            }

            return uniqueWords;
        }

        public static string[] UncommonFromSentences2(string s1, string s2)
        {
            Dictionary<string, int> wordsFrequencies = new Dictionary<string, int>();

            foreach (var word in s1.Split(' '))
            {
                if (wordsFrequencies.ContainsKey(word))
                {
                    wordsFrequencies[word]++;
                }
                else
                {
                    wordsFrequencies.Add(word, 1);
                }
            }

            foreach (var word in s2.Split(' '))
            {
                if (wordsFrequencies.ContainsKey(word))
                {
                    wordsFrequencies[word]++;
                }
                else
                {
                    wordsFrequencies.Add(word, 1);
                }
            }

            List<string> uncommonWords = new List<string>();

            foreach (var kvp in wordsFrequencies)
            {
                if (kvp.Value == 1)
                {
                    uncommonWords.Add(kvp.Key);
                }
            }

            return uncommonWords.ToArray();
        }
    }
}
