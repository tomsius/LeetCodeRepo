using System;

namespace _1455._Check_If_a_Word_Occurs_As_a_Prefix_of_Any_Word_in_a_Sentence
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence1 = "i love eating burger";
            string searchWord1 = "burg";
            Console.WriteLine(IsPrefixOfWord(sentence1, searchWord1));

            string sentence2 = "this problem is an easy problem";
            string searchWord2 = "pro";
            Console.WriteLine(IsPrefixOfWord(sentence2, searchWord2));

            string sentence3 = "i am tired";
            string searchWord3 = "you";
            Console.WriteLine(IsPrefixOfWord(sentence3, searchWord3));

            string sentence4 = "i use triple pillow";
            string searchWord4 = "pill";
            Console.WriteLine(IsPrefixOfWord(sentence4, searchWord4));

            string sentence5 = "hello from the other side";
            string searchWord5 = "they";
            Console.WriteLine(IsPrefixOfWord(sentence5, searchWord5));
        }

        public static int IsPrefixOfWord(string sentence, string searchWord)
        {
            string[] words = sentence.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].StartsWith(searchWord))
                {
                    return i + 1;
                }
            }

            return -1;
        }
    }
}
