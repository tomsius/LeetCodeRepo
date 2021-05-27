using System;
using System.Collections.Generic;
using System.Text;

namespace _1021._Remove_Outermost_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "(()())(())";
            Console.WriteLine(RemoveOuterParentheses1(s1));

            Console.WriteLine(RemoveOuterParentheses2(s1));

            string s2 = "(()())(())(()(()))";
            Console.WriteLine(RemoveOuterParentheses1(s2));
            Console.WriteLine(RemoveOuterParentheses2(s2));

            string s3 = "()()";
            Console.WriteLine(RemoveOuterParentheses1(s3));
            Console.WriteLine(RemoveOuterParentheses2(s3));
        }

        public static string RemoveOuterParentheses1(string s)
        {
            List<string> decompositions = GetDecompositions(s);

            return string.Join("", decompositions);
        }

        private static List<string> GetDecompositions(string s)
        {
            List<string> decompositions = new List<string>();
            int start = 0;

            for (int i = 1; i < s.Length - 1; i++)
            {
                int paranthesesDiff = 1;

                while (paranthesesDiff != 0)
                {
                    if (s[i] == '(')
                    {
                        paranthesesDiff++;
                    }
                    else
                    {
                        paranthesesDiff--;
                    }

                    i++;
                }

                decompositions.Add(s.Substring(start + 1, i - start - 2));
                start = i;
            }

            return decompositions;
        }

        public static string RemoveOuterParentheses2(string s)
        {
            StringBuilder sb = new StringBuilder();
            int start = 0;

            for (int i = 1; i < s.Length - 1; i++)
            {
                int paranthesesDiff = 1;

                while (paranthesesDiff != 0)
                {
                    if (s[i] == '(')
                    {
                        paranthesesDiff++;
                    }
                    else
                    {
                        paranthesesDiff--;
                    }

                    i++;
                }

                sb.Append(s.Substring(start + 1, i - start - 2));
                start = i;
            }

            return sb.ToString();
        }
    }
}
