using System;

namespace _1704._Determine_if_String_Halves_Are_Alike
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "book";
            Console.WriteLine(HalvesAreAlike(s1));

            string s2 = "textbook";
            Console.WriteLine(HalvesAreAlike(s2));

            string s3 = "MerryChristmas";
            Console.WriteLine(HalvesAreAlike(s3));

            string s4 = "AbCdEfGh";
            Console.WriteLine(HalvesAreAlike(s4));
        }

        public static bool HalvesAreAlike(string s)
        {
            int vowelDiff = 0;
            string vowels = "aeiouAEIOU";

            for (int i = 0; i < s.Length / 2; i++)
            {
                if (vowels.Contains(s[i]))
                {
                    vowelDiff++;
                }
                
                if (vowels.Contains(s[s.Length / 2 + i]))
                {
                    vowelDiff--;
                }
            }

            return vowelDiff == 0;
        }
    }
}
