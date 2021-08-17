using System;
using System.Collections.Generic;
using System.Text;

namespace _1544._Make_The_String_Great
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "leEeetcode";
            Console.WriteLine(MakeGood1(s1));
            Console.WriteLine(MakeGood2(s1));

            string s2 = "abBAcC";
            Console.WriteLine(MakeGood1(s2));
            Console.WriteLine(MakeGood2(s2));

            string s3 = "s";
            Console.WriteLine(MakeGood1(s3));
            Console.WriteLine(MakeGood2(s3));
        }

        public static string MakeGood1(string s)
        {
            StringBuilder sb = new StringBuilder(s);

            for (int i = 0; i <= sb.Length - 2; i++)
            {
                if ((char.IsUpper(sb[i]) && char.IsLower(sb[i + 1]) && char.ToLower(sb[i]) == char.ToLower(sb[i + 1])) || 
                    (char.IsLower(sb[i]) && char.IsUpper(sb[i + 1]) && char.ToLower(sb[i]) == char.ToLower(sb[i + 1])))
                {
                    sb.Remove(i, 2);
                    i = Math.Max(-1, i - 2);
                }
            }

            return sb.ToString();
        }

        public static string MakeGood2(string s)
        {
            Stack<char> letters = new Stack<char>(s.Length);

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (letters.Count == 0)
                {
                    letters.Push(s[i]);
                }
                else if ((char.IsUpper(letters.Peek()) && char.IsLower(s[i]) && char.ToLower(letters.Peek()) == char.ToLower(s[i])) ||
                         (char.IsLower(letters.Peek()) && char.IsUpper(s[i]) && char.ToLower(letters.Peek()) == char.ToLower(s[i])))
                {
                    letters.Pop();
                }
                else
                {
                    letters.Push(s[i]);
                }
            }

            return new string(letters.ToArray());
        }
    }
}
