using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1221.Split_a_String_in_Balanced_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "RLRRLLRLRL";
            Console.WriteLine(BalancedStringSplit(s1));

            string s2 = "RLLLLRRRLR";
            Console.WriteLine(BalancedStringSplit(s2));

            string s3 = "LLLLRRRR";
            Console.WriteLine(BalancedStringSplit(s3));

            string s4 = "RLRRRLLRLL";
            Console.WriteLine(BalancedStringSplit(s4));

            Console.ReadKey();
        }

        public static int BalancedStringSplit(string s)
        {
            int count = 0;
            int output = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Equals('R'))
                {
                    count++;
                }
                else if (s[i].Equals('L'))
                {
                    count--;
                }
                if (count == 0)
                    output++;
            }

            return output;
        }
    }
}
