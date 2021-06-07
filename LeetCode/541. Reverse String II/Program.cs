using System;

namespace _541._Reverse_String_II
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "abcdefg";
            int k1 = 2;
            Console.WriteLine(s1 + " => " + ReverseStr(s1, k1));

            string s2 = "abcd";
            int k2 = 2;
            Console.WriteLine(s2 + " => " + ReverseStr(s2, k2));

            string s3 = "abcdef";
            int k3 = 3;
            Console.WriteLine(s3 + " => " + ReverseStr(s3, k3));

            string s4 = "a";
            int k4 = 2;
            Console.WriteLine(s4 + " => " + ReverseStr(s4, k4));

            string s5 = "abcdefg";
            int k5 = 3;
            Console.WriteLine(s5 + " => " + ReverseStr(s5, k5));
        }

        public static string ReverseStr(string s, int k)
        {
            char[] word = s.ToCharArray();

            for (int i = 0; i < word.Length; i = i + 2 * k)
            {
                if (k > s.Substring(i).Length)
                {
                    Array.Reverse(word, i, word.Length - i);
                }
                else
                {
                    Array.Reverse(word, i, k);
                }
            }

            return new string(word);
        }
    }
}
