using System;
using System.Collections.Generic;
using System.Text;

namespace _1047._Remove_All_Adjacent_Duplicates_In_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "abbaca";
            Console.WriteLine(RemoveDuplicates1(s1));
            Console.WriteLine(RemoveDuplicates2(s1));

            string s2 = "azxxzy";
            Console.WriteLine(RemoveDuplicates1(s2));
            Console.WriteLine(RemoveDuplicates2(s2));
        }

        public static string RemoveDuplicates1(string s)
        {
            StringBuilder sb = new StringBuilder();
            int sbIndex = 0;
            sb.Append(s[0]);

            for (int i = 1; i < s.Length; i++)
            {
                if (sb.Length > 0 && sb[sbIndex] == s[i])
                {
                    sb.Remove(sbIndex, 1);
                    sbIndex--;
                }
                else
                {
                    sb.Append(s[i]);
                    sbIndex++;
                }
            }

            return sb.ToString();
        }

        public static string RemoveDuplicates2(string s)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(s[0]);

            for (int i = 1; i < s.Length; i++)
            {
                if (sb.Length > 0 && sb[sb.Length - 1] == s[i])
                {
                    sb.Remove(sb.Length - 1, 1);
                }
                else
                {
                    sb.Append(s[i]);
                }
            }

            return sb.ToString();
        }
    }
}
