using System;

namespace _557._Reverse_Words_in_a_String_III
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Let's take LeetCode contest";
            Console.WriteLine(s1 + " => " + ReverseWords(s1));

            string s2 = "God Ding";
            Console.WriteLine(s2 + " => " + ReverseWords(s2));
        }

        public static string ReverseWords(string s)
        {
            string[] words = s.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                char[] word = words[i].ToCharArray();
                Array.Reverse(word);

                words[i] = new string(word);
            }

            return String.Join(" ", words);
        }
    }
}
