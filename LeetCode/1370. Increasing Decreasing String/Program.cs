using System;
using System.Text;

namespace _1370._Increasing_Decreasing_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "aaaabbbbcccc";
            Console.WriteLine(SortString1(s1));

            string s2 = "rat";
            Console.WriteLine(SortString1(s2));

            string s3 = "leetcode";
            Console.WriteLine(SortString1(s3));

            string s4 = "ggggggg";
            Console.WriteLine(SortString1(s4));

            string s5 = "spo";
            Console.WriteLine(SortString1(s5));
        }

        public static string SortString1(string s)
        {
            StringBuilder sb = new StringBuilder();
            int[] occurances = new int['z' - 'a' + 1];

            foreach (var letter in s)
            {
                occurances[letter - 'a']++;
            }

            while (true)
            {
                int empty = 0;
                for (int i = 0; i < occurances.Length; i++)
                {
                    if (occurances[i] != 0)
                    {
                        sb.Append((char)(i + 'a'));
                        occurances[i]--;
                    }
                    else
                    {
                        empty++;
                    }
                }

                if (empty == occurances.Length)
                {
                    break;
                }

                empty = 0;

                for (int i = occurances.Length - 1; i >= 0; i--)
                {
                    if (occurances[i] != 0)
                    {
                        sb.Append((char)(i + 'a'));
                        occurances[i]--;
                    }
                    else
                    {
                        empty++;
                    }
                }

                if (empty == occurances.Length)
                {
                    break;
                }
            }

            return sb.ToString();
        }
    }
}
