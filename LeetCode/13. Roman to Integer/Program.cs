using System;
using System.Collections.Generic;

namespace _13._Roman_to_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "III";
            Console.WriteLine(RomanToInt(s1));

            string s2 = "IV";
            Console.WriteLine(RomanToInt(s2));

            string s3 = "IX";
            Console.WriteLine(RomanToInt(s3));

            string s4 = "LVIII";
            Console.WriteLine(RomanToInt(s4));

            string s5 = "MCMXCIV";
            Console.WriteLine(RomanToInt(s5));
        }

        public static int RomanToInt(string s)
        {
            Dictionary<char, int> romanToArabic = new Dictionary<char, int>() 
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 },
            };
            int arabicValue = romanToArabic[s[0]];

            for (int i = 1; i < s.Length; i++)
            {
                arabicValue += romanToArabic[s[i]];

                if (s[i - 1] == 'I' && (s[i] == 'V' || s[i] == 'X'))
                {
                    arabicValue -= 2 * romanToArabic[s[i - 1]];
                }

                if (s[i - 1] == 'X' && (s[i] == 'L' || s[i] == 'C'))
                {
                    arabicValue -= 2 * romanToArabic[s[i - 1]];
                }

                if (s[i - 1] == 'C' && (s[i] == 'D' || s[i] == 'M'))
                {
                    arabicValue -= 2 * romanToArabic[s[i - 1]];
                }
            }

            return arabicValue;
        }
    }
}
