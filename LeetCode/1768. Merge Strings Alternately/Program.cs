using System;
using System.Text;

namespace _1768._Merge_Strings_Alternately
{
    class Program
    {
        static void Main(string[] args)
        {
            string word11 = "abc";
            string word21 = "pqr";
            Console.WriteLine(MergeAlternately(word11, word21));

            string word12 = "ab";
            string word22 = "pqrs";
            Console.WriteLine(MergeAlternately(word12, word22));

            string word13 = "abcd";
            string word23 = "pq";
            Console.WriteLine(MergeAlternately(word13, word23));
        }

        public static string MergeAlternately(string word1, string word2)
        {
            StringBuilder sb = new StringBuilder();
            int index = 0;

            while (index < word1.Length && index < word2.Length)
            {
                sb.Append(word1[index]);
                sb.Append(word2[index]);

                index++;
            }

            if (index < word1.Length)
            {
                sb.Append(word1.Substring(index));
            }
            else if (index < word2.Length)
            {
                sb.Append(word2.Substring(index));
            }

            return sb.ToString();
        }
    }
}
