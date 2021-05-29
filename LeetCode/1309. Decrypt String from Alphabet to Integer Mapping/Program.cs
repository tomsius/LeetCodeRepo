using System;
using System.Text;

namespace _1309._Decrypt_String_from_Alphabet_to_Integer_Mapping
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "10#11#12";
            Console.WriteLine(FreqAlphabets(s1));

            string s2 = "1326#";
            Console.WriteLine(FreqAlphabets(s2));

            string s3 = "25#";
            Console.WriteLine(FreqAlphabets(s3));

            string s4 = "12345678910#11#12#13#14#15#16#17#18#19#20#21#22#23#24#25#26#";
            Console.WriteLine(FreqAlphabets(s4));
        }

        public static string FreqAlphabets(string s)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                if (i + 2 < s.Length && s[i + 2] == '#')
                {
                    sb.Append(DecodeChar(s.Substring(i, 2)));
                    i += 2;
                }
                else
                {
                    sb.Append(DecodeChar(s.Substring(i, 1)));
                }
            }

            return sb.ToString();
        }

        public static char DecodeChar(string number)
        {
            int num = int.Parse(number);
            char decodedChar = (char)(num + 'a' - 1);

            return decodedChar;
        }
    }
}
