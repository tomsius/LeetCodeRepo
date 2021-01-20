using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1684.Count_the_Number_of_Consistent_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string allowed1 = "ab";
            string[] words1 = { "ad", "bd", "aaab", "baa", "badab" };
            Console.WriteLine(CountConsistentStrings(allowed1, words1));

            string allowed2 = "abc";
            string[] words2 = { "a", "b", "c", "ab", "ac", "bc", "abc" };
            Console.WriteLine(CountConsistentStrings(allowed2, words2));

            string allowed3 = "cad";
            string[] words3 = { "cc", "acd", "b", "ba", "bac", "bad", "ac", "d" };
            Console.WriteLine(CountConsistentStrings(allowed3, words3));

            Console.ReadKey();
        }

        public static int CountConsistentStrings(string allowed, string[] words)
        {
            int output = 0;
            HashSet<char> allowedChars = new HashSet<char>(allowed);

            foreach (string word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (!allowed.Contains(word[i]))
                    {
                        break;
                    }
                    if (i == word.Length - 1)
                    {
                        output++;
                    }
                }
            }

            return output;
        }
    }
}
