using System;
using System.Collections.Generic;
using System.Linq;

namespace _1408._String_Matching_in_an_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words1 = { "mass", "as", "hero", "superhero" };
            Console.WriteLine(String.Join(", ", StringMatching1(words1)));
            Console.WriteLine(String.Join(", ", StringMatching2(words1)));

            string[] words2 = { "leetcode","et","code" };
            Console.WriteLine(String.Join(", ", StringMatching1(words2)));
            Console.WriteLine(String.Join(", ", StringMatching2(words2)));

            string[] words3 = { "blue", "green", "bu" };
            Console.WriteLine(String.Join(", ", StringMatching1(words3)));
            Console.WriteLine(String.Join(", ", StringMatching2(words3)));

            string[] words4 = { "leetcoder", "leetcode", "od", "hamlet", "am" };
            Console.WriteLine(String.Join(", ", StringMatching1(words4)));
            Console.WriteLine(String.Join(", ", StringMatching2(words4)));
        }

        public static IList<string> StringMatching1(string[] words)
        {
            HashSet<string> matches = new HashSet<string>(words.Length);

            foreach (var word in words)
            {
                foreach (var potentialMatch in words)
                {
                    if (potentialMatch != word && word.Contains(potentialMatch))
                    {
                        matches.Add(potentialMatch);
                    }
                }
            }

            return matches.ToList();
        }

        public static IList<string> StringMatching2(string[] words)
        {
            HashSet<string> matches = new HashSet<string>(words.Length);

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    if (words[i].Contains(words[j]))
                    {
                        matches.Add(words[j]);
                    }

                    if (words[j].Contains(words[i]))
                    {
                        matches.Add(words[i]);
                    }
                }
            }

            return matches.ToList();
        }
    }
}
