using System;

namespace _1160._Find_Words_That_Can_Be_Formed_by_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words1 = { "cat", "bt", "hat", "tree" };
            string chars1 = "atach";
            Console.WriteLine(CountCharacters(words1, chars1));

            string[] words2 = { "hello", "world", "leetcode" };
            string chars2 = "welldonehoneyr";
            Console.WriteLine(CountCharacters(words2, chars2));
        }

        public static int CountCharacters(string[] words, string chars)
        {
            int goodStringsLengthSum = 0;
            int[] availableLetters = new int['z' - 'a' + 1];

            foreach (var letter in chars)
            {
                availableLetters[letter - 'a']++;
            }

            foreach (var word in words)
            {
                int[] availableLettersCopy = new int['z' - 'a' + 1];
                Array.Copy(availableLetters, availableLettersCopy, availableLetters.Length);
                bool isGoodString = true;

                foreach (var letter in word)
                {
                    if (availableLettersCopy[letter - 'a'] > 0)
                    {
                        availableLettersCopy[letter - 'a']--;
                    }
                    else
                    {
                        isGoodString = false;
                        break;
                    }
                }

                if (isGoodString)
                {
                    goodStringsLengthSum += word.Length;
                }
            }

            return goodStringsLengthSum;
        }
    }
}
