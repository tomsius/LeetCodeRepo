using System;

namespace _1876._Substrings_of_Size_Three_with_Distinct_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "xyzzaz";
            Console.WriteLine(CountGoodSubstrings(s1));

            string s2 = "aababcabc";
            Console.WriteLine(CountGoodSubstrings(s2));
        }

        public static int CountGoodSubstrings(string s)
        {
            int goodSubstringsCount = 0;

            for (int i = 0; i < s.Length - 2; i++)
            {
                if (s[i] != s[i + 1] && s[i] != s[i + 2] && s[i + 1] != s[i + 2])
                {
                    goodSubstringsCount++;
                }
            }

            return goodSubstringsCount;
        }
    }
}
