using System;
using System.Collections.Generic;

namespace _1941._Check_if_All_Characters_Have_Equal_Number_of_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "abacbc";
            Console.WriteLine(AreOccurrencesEqual(s1));

            string s2 = "aaabb";
            Console.WriteLine(AreOccurrencesEqual(s2));
        }

        public static bool AreOccurrencesEqual(string s)
        {
            Dictionary<char, int> occurances = new Dictionary<char, int>();

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

            int expectedNumber = occurances[s[0]];

            foreach (var kvp in occurances)
            {
                if (kvp.Value != expectedNumber)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
