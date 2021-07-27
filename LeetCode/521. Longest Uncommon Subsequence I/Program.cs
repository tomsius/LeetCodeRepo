using System;
using System.Collections.Generic;

namespace _521._Longest_Uncommon_Subsequence_I
{
    class Program
    {
        static void Main(string[] args)
        {
            string a1 = "aba";
            string b1 = "cdc";
            Console.WriteLine(FindLUSlength(a1, b1));

            string a2 = "aaa";
            string b2 = "bbb";
            Console.WriteLine(FindLUSlength(a2, b2));

            string a3 = "aaa";
            string b3 = "aaa";
            Console.WriteLine(FindLUSlength(a3, b3));
        }

        public static int FindLUSlength(string a, string b)
        {
            if (a.Equals(b))
            {
                return -1;
            }
            else
            {
                return Math.Max(a.Length, b.Length);
            }
        }
    }
}
