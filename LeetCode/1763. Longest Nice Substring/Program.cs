using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1763._Longest_Nice_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "YazaAay";
            Console.WriteLine(LongestNiceSubstring(s1));

            string s2 = "Bb";
            Console.WriteLine(LongestNiceSubstring(s2));

            string s3 = "c";
            Console.WriteLine(LongestNiceSubstring(s3));

            string s4 = "dDzeE";
            Console.WriteLine(LongestNiceSubstring(s4));
        }

        public static string LongestNiceSubstring(string s)
        {
            if (IsNice(s))
            {
                return s;
            }

            List<string> niceSubstrings = new List<string>();

            for (int i = 0; i < s.Length; i++)
            {
                StringBuilder sb = new StringBuilder(s[i].ToString());

                for (int j = i + 1; j < s.Length; j++)
                {
                    sb.Append(s[j]);

                    if (IsNice(sb.ToString()))
                    {
                        niceSubstrings.Add(sb.ToString());
                    }
                }
            }

            string longestNiceSubstring = niceSubstrings.OrderByDescending(x => x.Length).FirstOrDefault();

            return longestNiceSubstring != null ? longestNiceSubstring : "";
        }

        private static bool IsNice(string s)
        {
            HashSet<char> uniqueLetters = s.ToHashSet();

            foreach (var letter in s)
            {
                if (char.IsUpper(letter))
                {
                    if (!uniqueLetters.Contains(char.ToLower(letter)))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!uniqueLetters.Contains(char.ToUpper(letter)))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
