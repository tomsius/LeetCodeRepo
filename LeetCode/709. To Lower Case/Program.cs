using System;

namespace _709._To_Lower_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello";
            Console.WriteLine(ToLowerCase(s1));

            string s2 = "here";
            Console.WriteLine(ToLowerCase(s2));

            string s3 = "LOVELY";
            Console.WriteLine(ToLowerCase(s3));
        }

        public static string ToLowerCase(string s)
        {
            return s.ToLower();
        }
    }
}
