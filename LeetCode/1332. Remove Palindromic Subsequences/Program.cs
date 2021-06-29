using System;
using System.Text;

namespace _1332._Remove_Palindromic_Subsequences
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "ababa";
            Console.WriteLine(RemovePalindromeSub(s1));

            string s2 = "abb";
            Console.WriteLine(RemovePalindromeSub(s2));

            string s3 = "baabb";
            Console.WriteLine(RemovePalindromeSub(s3));
        }

        public static int RemovePalindromeSub(string s)
        {
            int startIndex = 0;
            int endIndex = s.Length - 1;

            while (startIndex <= endIndex)
            {
                if (s[startIndex] != s[endIndex])
                {
                    return 2;
                }

                startIndex++;
                endIndex--;
            }

            return 1;
        }
    }
}
