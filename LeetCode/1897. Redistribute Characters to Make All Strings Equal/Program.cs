using System;
using System.Collections.Generic;

namespace _1897._Redistribute_Characters_to_Make_All_Strings_Equal
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words1 = { "abc", "aabc", "bc" };
            Console.WriteLine(MakeEqual1(words1));
            Console.WriteLine(MakeEqual2(words1));

            string[] words2 = { "ab", "a" };
            Console.WriteLine(MakeEqual1(words2));
            Console.WriteLine(MakeEqual2(words2));
        }

        public static bool MakeEqual1(string[] words)
        {
            Dictionary<char, int> occurances = new Dictionary<char, int>();

            foreach (var word in words)
            {
                foreach (var letter in word)
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
            }

            foreach (var kvp in occurances)
            {
                if (kvp.Value % words.Length != 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool MakeEqual2(string[] words)
        {
            int[] occurances = new int['z' - 'a' + 1];

            foreach (var word in words)
            {
                foreach (var letter in word)
                {
                    occurances[letter - 'a']++;
                }
            }

            foreach (var occurance in occurances)
            {
                if (occurance != 0 && occurance % words.Length != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
