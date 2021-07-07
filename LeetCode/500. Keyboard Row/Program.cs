using System;
using System.Collections.Generic;

namespace _500._Keyboard_Row
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words1 = { "Hello", "Alaska", "Dad", "Peace" };
            Console.WriteLine(String.Join(", ", FindWords1(words1)));
            Console.WriteLine(String.Join(", ", FindWords2(words1)));

            string[] words2 = { "omk" };
            Console.WriteLine(String.Join(", ", FindWords1(words2)));
            Console.WriteLine(String.Join(", ", FindWords2(words2)));

            string[] words3 = { "adsdf", "sfd" };
            Console.WriteLine(String.Join(", ", FindWords1(words3)));
            Console.WriteLine(String.Join(", ", FindWords2(words3)));

            string[] words4 = { "qwee" };
            Console.WriteLine(String.Join(", ", FindWords1(words4)));
            Console.WriteLine(String.Join(", ", FindWords2(words4)));
        }

        public static string[] FindWords1(string[] words)
        {
            List<string> wordsFromOneKeyboardRow = new List<string>(words.Length);

            foreach (var word in words)
            {
                if (IsWordFromOneKeyboardRow(word))
                {
                    wordsFromOneKeyboardRow.Add(word);
                }
            }

            return wordsFromOneKeyboardRow.ToArray();
        }

        private static bool IsWordFromOneKeyboardRow(string word)
        {
            string[] keyboardRows = { "qwertyuiop", "asdfghjkl", "zxcvbnm" };
            int keyboardRowIndex = 0;

            if (keyboardRows[1].Contains(char.ToLower(word[0])))
            {
                keyboardRowIndex = 1;
            }
            else if (keyboardRows[2].Contains(char.ToLower(word[0])))
            {
                keyboardRowIndex = 2;
            }

            for (int i = 1; i < word.Length; i++)
            {
                if (!keyboardRows[keyboardRowIndex].Contains(char.ToLower(word[i])))
                {
                    return false;
                }
            }

            return true;
        }

        private static string[] FindWords2(string[] words)
        {
            string[] keyboardRows = { "qwertyuiop", "asdfghjkl", "zxcvbnm" };
            List<string> wordsFromOneKeyboardRow = new List<string>(words.Length);

            foreach (var word in words)
            {
                if (CanBeCreatedWithKeyboardRow(word, keyboardRows[0]) || CanBeCreatedWithKeyboardRow(word, keyboardRows[1]) || CanBeCreatedWithKeyboardRow(word, keyboardRows[2]))
                {
                    wordsFromOneKeyboardRow.Add(word);
                }
            }

            return wordsFromOneKeyboardRow.ToArray();
        }

        private static bool CanBeCreatedWithKeyboardRow(string word, string keyboardRow)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (!keyboardRow.Contains(char.ToLower(word[i])))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
