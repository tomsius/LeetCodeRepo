using System;
using System.Linq;

namespace _1935._Maximum_Number_of_Words_You_Can_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            string text1 = "hello world";
            string brokenLetters1 = "ad";
            Console.WriteLine(CanBeTypedWords(text1, brokenLetters1));

            string text2 = "leet code";
            string brokenLetters2 = "lt";
            Console.WriteLine(CanBeTypedWords(text2, brokenLetters2));

            string text3 = "leet code";
            string brokenLetters3 = "e";
            Console.WriteLine(CanBeTypedWords(text3, brokenLetters3));
        }

        public static int CanBeTypedWords(string text, string brokenLetters)
        {
            int numberOfWords = 0;
            string[] words = text.Split(' ');
            char[] broken = brokenLetters.ToCharArray();

            foreach (var word in words)
            {
                bool canBeTyped = true;

                foreach (var letter in word)
                {
                    if (broken.Contains(letter))
                    {
                        canBeTyped = false;
                        break;
                    }
                }

                if (canBeTyped)
                {
                    numberOfWords++;
                }
            }

            return numberOfWords;
        }
    }
}
