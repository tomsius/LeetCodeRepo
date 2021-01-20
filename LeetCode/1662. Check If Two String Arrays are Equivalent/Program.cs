using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1662.Check_If_Two_String_Arrays_are_Equivalent
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] word11 = { "ab", "c" };
            string[] word12 = { "a", "bc" };
            Console.WriteLine(ArrayStringsAreEqual(word11, word12));

            string[] word21 = { "a", "cb" };
            string[] word22 = { "ab", "c" };
            Console.WriteLine(ArrayStringsAreEqual(word21, word22));

            string[] word31 = { "abc", "d", "defg" };
            string[] word32 = { "abcddefg" };
            Console.WriteLine(ArrayStringsAreEqual(word31, word32));

            Console.ReadKey();
        }

        public static bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();

            for (int i = 0; i < word1.Length; i++)
            {
                sb1.Append(word1[i]);
            }

            for (int i = 0; i < word2.Length; i++)
            {
                sb2.Append(word2[i]);
            }

            return sb1.ToString().Equals(sb2.ToString());
        }
    }
}
