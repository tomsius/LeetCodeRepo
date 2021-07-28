using System;

namespace _1624._Largest_Substring_Between_Two_Equal_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "aa";
            Console.WriteLine(MaxLengthBetweenEqualCharacters1(s1));
            Console.WriteLine(MaxLengthBetweenEqualCharacters2(s1));

            string s2 = "abca";
            Console.WriteLine(MaxLengthBetweenEqualCharacters1(s2));
            Console.WriteLine(MaxLengthBetweenEqualCharacters2(s2));

            string s3 = "cbzxy";
            Console.WriteLine(MaxLengthBetweenEqualCharacters1(s3));
            Console.WriteLine(MaxLengthBetweenEqualCharacters2(s3));

            string s4 = "cabbac";
            Console.WriteLine(MaxLengthBetweenEqualCharacters1(s4));
            Console.WriteLine(MaxLengthBetweenEqualCharacters2(s4));
        }

        public static int MaxLengthBetweenEqualCharacters1(string s)
        {
            int longestSubstring = int.MinValue;

            for (int i = 0; i < s.Length; i++)
            {
                int firstIndex = s.IndexOf(s[i]);
                int lastIndex = s.LastIndexOf(s[i]);

                longestSubstring = Math.Max(longestSubstring, lastIndex - firstIndex - 1);
            }

            return longestSubstring;
        }

        public static int MaxLengthBetweenEqualCharacters2(string s)
        {
            int[] lettersStartIndices = new int['z' - 'a' + 1];
            int longestSubstring = -1;

            for (int i = 0; i < s.Length; i++)
            {
                if (lettersStartIndices[s[i] - 'a'] == 0)
                {
                    lettersStartIndices[s[i] - 'a'] = i + 1;
                }
                else
                {
                    longestSubstring = Math.Max(longestSubstring, i + 1 - lettersStartIndices[s[i] - 'a'] - 1);
                }
            }

            return longestSubstring;
        }
    }
}
