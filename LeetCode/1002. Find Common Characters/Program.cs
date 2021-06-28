using System;
using System.Collections.Generic;

namespace _1002._Find_Common_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words1 = { "bella", "label", "roller" };
            Console.WriteLine(String.Join(", ", CommonChars(words1)));

            string[] words2 = { "cool", "lock", "cook" };
            Console.WriteLine(String.Join(", ", CommonChars(words2)));

            string[] words3 = { "acabcddd", "bcbdbcbd", "baddbadb", "cbdddcac", "aacbcccd", "ccccddda", "cababaab", "addcaccd" };
            Console.WriteLine(String.Join(", ", CommonChars(words3)));
        }

        public static IList<string> CommonChars(string[] words)
        {
            IList<string> commonChars = new List<string>();
            int[,] lettersInWord = new int[words.Length, 'z' - 'a' + 1];

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    lettersInWord[i, words[i][j] - 'a']++;
                }
            }

            for (int column = 0; column < 'z' - 'a' + 1; column++)
            {
                int minimumOccurances = int.MaxValue;

                for (int row = 0; row < words.Length; row++)
                {
                    if (lettersInWord[row, column] == 0)
                    {
                        minimumOccurances = 0;
                        break;
                    }
                    else if (lettersInWord[row, column] < minimumOccurances)
                    {
                        minimumOccurances = lettersInWord[row, column];
                    }
                }

                while (minimumOccurances > 0)
                {
                    commonChars.Add(((char)(column + 'a')).ToString());
                    minimumOccurances--;
                }
            }

            return commonChars;
        }
    }
}
