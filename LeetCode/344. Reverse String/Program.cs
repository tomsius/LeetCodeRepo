using System;

namespace _344._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] s1 = { 'h', 'e', 'l', 'l', 'o' };
            Console.Write(new string(s1) + " => ");
            ReverseString1(s1);
            Console.WriteLine(new string(s1));

            s1 = new char[]{ 'h', 'e', 'l', 'l', 'o' };
            Console.Write(new string(s1) + " => ");
            ReverseString2(s1);
            Console.WriteLine(new string(s1));

            char[] s2 = { 'H', 'a', 'n', 'n', 'a', 'h' };
            Console.Write(new string(s2) + " => ");
            ReverseString1(s2);
            Console.WriteLine(new string(s2));

            s2 = new char[]{ 'H', 'a', 'n', 'n', 'a', 'h' };
            Console.Write(new string(s2) + " => ");
            ReverseString2(s2);
            Console.WriteLine(new string(s2));
        }

        public static void ReverseString1(char[] s)
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                char temp = s[i];
                s[i] = s[s.Length - i - 1];
                s[s.Length - i - 1] = temp;
            }
        }

        public static void ReverseString2(char[] s)
        {
            Array.Reverse(s);
        }
    }
}
