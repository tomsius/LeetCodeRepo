using System;
using System.Collections.Generic;

namespace _696._Count_Binary_Substrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "00110011";
            Console.WriteLine(CountBinarySubstrings1(s1));
            Console.WriteLine(CountBinarySubstrings2(s1));

            string s2 = "10101";
            Console.WriteLine(CountBinarySubstrings1(s2));
            Console.WriteLine(CountBinarySubstrings2(s2));
        }

        public static int CountBinarySubstrings1(string s)
        {
            List<int> groups = new List<int>();
            groups.Add(1);

            int index = 0;

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i - 1] != s[i])
                {
                    index++;
                    groups.Add(1);
                }
                else
                {
                    groups[index]++;
                }
            }

            int count = 0;

            for (int i = 1; i < groups.Count; i++)
            {
                count += Math.Min(groups[i - 1], groups[i]);
            }

            return count;
        }

        public static int CountBinarySubstrings2(string s)
        {
            int count = 0;
            int prev = 0;
            int cur = 1;

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i - 1] != s[i])
                {
                    count += Math.Min(prev, cur);
                    prev = cur;
                    cur = 1;
                }
                else
                {
                    cur++;
                }
            }

            count += Math.Min(prev, cur);

            return count;
        }
    }
}
