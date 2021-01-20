using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1614.Maximum_Nesting_Depth_of_the_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "(1+(2*3)+((8)/4))+1";
            Console.WriteLine(MaxDepth(s1));
            Console.WriteLine(MaxDepth2(s1));

            string s2 = "(1)+((2))+(((3)))";
            Console.WriteLine(MaxDepth(s2));
            Console.WriteLine(MaxDepth2(s2));

            string s3 = "1+(2*3)/(2-1)";
            Console.WriteLine(MaxDepth(s3));
            Console.WriteLine(MaxDepth2(s3));

            string s4 = "1";
            Console.WriteLine(MaxDepth(s4));
            Console.WriteLine(MaxDepth2(s4));

            Console.ReadKey();
        }

        public static int MaxDepth(string s)
        {
            int max = 0;
            Stack<char> parentheses = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Equals('('))
                {
                    parentheses.Push(s[i]);
                }
                else if (s[i].Equals(')'))
                {
                    max = Math.Max(max, parentheses.Count);
                    parentheses.Pop();
                }
            }

            return max;
        }

        public static int MaxDepth2(string s)
        {
            int max = 0;
            int count = 0;

            foreach (char c in s)
            {
                if (c == '(')
                {
                    count++;
                    max = Math.Max(max, count);
                }

                else if (c == ')')
                {
                    count--;
                }
            }

            return max;
        }
    }
}
