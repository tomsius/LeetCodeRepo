using System;
using System.Collections.Generic;

namespace _387._First_Unique_Character_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "leetcode";
            Console.WriteLine(FirstUniqChar(s1));

            string s2 = "loveleetcode";
            Console.WriteLine(FirstUniqChar(s2));

            string s3 = "aabb";
            Console.WriteLine(FirstUniqChar(s3));
        }

        public static int FirstUniqChar(string s)
        {
            int[] letterCounts = new int['z' - 'a' + 1];

            foreach (var letter in s)
            {
                letterCounts[letter - 'a']++;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (letterCounts[s[i] - 'a'] == 1)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
