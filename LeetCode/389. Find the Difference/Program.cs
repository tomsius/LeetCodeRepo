using System;
using System.Collections.Generic;

namespace _389._Find_the_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "abcd";
            string t1 = "abcde";
            Console.WriteLine(FindTheDifference1(s1, t1));
            Console.WriteLine(FindTheDifference2(s1, t1));
            Console.WriteLine(FindTheDifference3(s1, t1));

            string s2 = "";
            string t2 = "y";
            Console.WriteLine(FindTheDifference1(s2, t2));
            Console.WriteLine(FindTheDifference2(s2, t2));
            Console.WriteLine(FindTheDifference3(s2, t2));

            string s3 = "a";
            string t3 = "aa";
            Console.WriteLine(FindTheDifference1(s3, t3));
            Console.WriteLine(FindTheDifference2(s3, t3));
            Console.WriteLine(FindTheDifference3(s3, t3));

            string s4 = "ae";
            string t4 = "aea";
            Console.WriteLine(FindTheDifference1(s4, t4));
            Console.WriteLine(FindTheDifference2(s4, t4));
            Console.WriteLine(FindTheDifference3(s4, t4));
        }

        public static char FindTheDifference1(string s, string t)
        {
            Dictionary<char, int> occurances = new Dictionary<char, int>(s.Length);
            char difference = ' ';

            foreach (var letter in s)
            {
                if (occurances.ContainsKey(letter))
                {
                    occurances[letter]++;
                }
                else
                {
                    occurances.Add(letter, 1);
                }
            }

            foreach (var letter in t)
            {
                if (occurances.ContainsKey(letter))
                {
                    if (occurances[letter] > 0)
                    {
                        occurances[letter]--;
                    }
                    else
                    {
                        difference = letter;
                        break;
                    }
                }
                else
                {
                    difference = letter;
                    break;
                }
            }

            return difference;
        }

        public static char FindTheDifference2(string s, string t)
        {
            int xorValue = t[t.Length - 1];

            for (int i = 0; i < s.Length; i++)
            {
                xorValue ^= s[i];
                xorValue ^= t[i];
            }

            return (char)xorValue;
        }

        public static char FindTheDifference3(string s, string t)
        {
            int originalSum = 0;
            int shuffledSum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                originalSum += s[i];
            }

            for (int i = 0; i < t.Length; i++)
            {
                shuffledSum += t[i];
            }

            return (char)(shuffledSum - originalSum);
        }
    }
}
