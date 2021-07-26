using System;
using System.Linq;

namespace _242._Valid_Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "anagram";
            string t1 = "nagaram";
            Console.WriteLine(IsAnagram1(s1, t1));
            Console.WriteLine(IsAnagram2(s1, t1));
            Console.WriteLine(IsAnagram3(s1, t1));

            string s2 = "rat";
            string t2 = "car";
            Console.WriteLine(IsAnagram1(s2, t2));
            Console.WriteLine(IsAnagram2(s2, t2));
            Console.WriteLine(IsAnagram3(s2, t2));
        }

        public static bool IsAnagram1(string s, string t)
        {
            int[] lettersOccurances = new int[26];

            foreach (var letter in s)
            {
                lettersOccurances[letter - 'a']++;
            }

            foreach (var letter in t)
            {
                lettersOccurances[letter - 'a']--;
            }

            foreach (var occurance in lettersOccurances)
            {
                if (occurance != 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsAnagram2(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            char[] sLetters = s.ToCharArray();
            char[] tLetters = t.ToCharArray();

            Array.Sort(sLetters);
            Array.Sort(tLetters);

            for (int i = 0; i < sLetters.Length; i++)
            {
                if (sLetters[i] != tLetters[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsAnagram3(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            int[] lettersOccurances = new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                lettersOccurances[s[i] - 'a']++;
                lettersOccurances[t[i] - 'a']--;
            }

            return lettersOccurances.All(x => x == 0);
        }
    }
}
