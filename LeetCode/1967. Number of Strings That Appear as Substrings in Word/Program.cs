using System;

namespace _1967._Number_of_Strings_That_Appear_as_Substrings_in_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] patterns1 = { "a", "abc", "bc", "d" };
            string word1 = "abc";
            Console.WriteLine(NumOfStrings(patterns1, word1));

            string[] patterns2 = { "a", "b", "c" };
            string word2 = "aaaaabbbbb";
            Console.WriteLine(NumOfStrings(patterns2, word2));

            string[] patterns3 = { "a", "a", "a" };
            string word3 = "ab";
            Console.WriteLine(NumOfStrings(patterns3, word3));
        }

        public static int NumOfStrings(string[] patterns, string word)
        {
            int substringsCount = 0;

            foreach (var pattern in patterns)
            {
                if (word.Contains(pattern))
                {
                    substringsCount++;
                }
            }

            return substringsCount;
        }
    }
}
