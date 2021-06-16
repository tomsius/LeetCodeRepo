using System;
using System.Collections.Generic;
using System.Text;

namespace _893._Groups_of_Special_Equivalent_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words1 = new string[] { "abcd", "cdab", "cbad", "xyzz", "zzxy", "zzyx" };
            Console.WriteLine(NumSpecialEquivGroups1(words1));
            Console.WriteLine(NumSpecialEquivGroups2(words1));

            string[] words2 = new string[] { "abc", "acb", "bac", "bca", "cab", "cba" };
            Console.WriteLine(NumSpecialEquivGroups1(words2));
            Console.WriteLine(NumSpecialEquivGroups2(words2));
        }

        public static int NumSpecialEquivGroups1(string[] words)
        {
            List<string> groupsFirstElements = new List<string>(words.Length);

            foreach (var word in words)
            {
                if (IsUniqueGroup(word, groupsFirstElements))
                {
                    groupsFirstElements.Add(word);
                }
            }

            return groupsFirstElements.Count;
        }

        private static bool IsUniqueGroup(string word, List<string> groups)
        {
            foreach (var group in groups)
            {
                if (IsSpecialGroup(word, group))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsSpecialGroup(string word, string group)
        {
            List<char> odd = new List<char>(word.Length / 2);
            List<char> even = new List<char>(word.Length / 2);

            for (int i = 0; i < word.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even.Add(word[i]);
                }
                else
                {
                    odd.Add(word[i]);
                }
            }

            for (int i = 0; i < group.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (even.Contains(group[i]))
                    {
                        even.Remove(group[i]);
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (odd.Contains(group[i]))
                    {
                        odd.Remove(group[i]);
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static int NumSpecialEquivGroups2(string[] words)
        {
            HashSet<string> groups = new HashSet<string>(words.Length);

            foreach (var word in words)
            {
                List<char> odd = new List<char>(word.Length / 2);
                List<char> even = new List<char>(word.Length / 2);

                for (int i = 0; i < word.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        even.Add(word[i]);
                    }
                    else
                    {
                        odd.Add(word[i]);
                    }
                }

                odd.Sort();
                even.Sort();
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < word.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        sb.Append(even[0]);
                        even.RemoveAt(0);
                    }
                    else
                    {
                        sb.Append(odd[0]);
                        odd.RemoveAt(0);
                    }
                }

                groups.Add(sb.ToString());
            }

            return groups.Count;
        }
    }
}
