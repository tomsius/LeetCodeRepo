using System;
using System.Text;

namespace _1961._Check_If_String_Is_a_Prefix_of_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "iloveleetcode";
            string[] words1 = { "i", "love", "leetcode", "apples" };
            Console.WriteLine(IsPrefixString1(s1, words1));
            Console.WriteLine(IsPrefixString2(s1, words1));

            string s2 = "iloveleetcode";
            string[] words2 = { "apples", "i", "love", "leetcode" };
            Console.WriteLine(IsPrefixString1(s2, words2));
            Console.WriteLine(IsPrefixString2(s2, words2));

            string s3 = "a";
            string[] words3 = { "aa", "aaaa", "banana" };
            Console.WriteLine(IsPrefixString1(s3, words3));
            Console.WriteLine(IsPrefixString2(s3, words3));

            string s4 = "ccccccccc";
            string[] words4 = { "c", "cc" };
            Console.WriteLine(IsPrefixString1(s4, words4));
            Console.WriteLine(IsPrefixString2(s4, words4));
        }

        public static bool IsPrefixString1(string s, string[] words)
        {
            int sIndex = 0;

            for (int i = 0; i < words.Length && sIndex < s.Length; i++)
            {
                if (s.Length - sIndex < words[i].Length)
                {
                    return false;
                }

                for (int j = 0; j < words[i].Length && sIndex < s.Length; j++, sIndex++)
                {
                    if (s[sIndex] != words[i][j])
                    {
                        return false;
                    }
                }
            }

            if (sIndex != s.Length)
            {
                return false;
            }

            return true;
        }

        public static bool IsPrefixString2(string s, string[] words)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var word in words)
            {
                sb.Append(word);

                if (sb.Length > s.Length)
                {
                    return false;
                }
                else if (sb.Length == s.Length)
                {
                    return s == sb.ToString();
                }
            }

            return false;
        }
    }
}
