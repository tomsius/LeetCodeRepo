using System;

namespace _1832._Check_if_the_Sentence_Is_Pangram
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = "thequickbrownfoxjumpsoverthelazydog";
            Console.WriteLine(CheckIfPangram(input1));

            string input2 = "leetcode";
            Console.WriteLine(CheckIfPangram(input2));
        }

        public static bool CheckIfPangram(string sentence)
        {
            int[] letters = new int['z' - 'a' + 1];

            foreach (var letter in sentence)
            {
                letters[letter - 'a']++;
            }

            foreach (var letterCount in letters)
            {
                if (letterCount == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
