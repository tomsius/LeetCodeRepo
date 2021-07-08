using System;

namespace _806._Number_of_Lines_To_Write_String
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] widths1 = { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };
            string s1 = "abcdefghijklmnopqrstuvwxyz";
            Console.WriteLine(String.Join(", ", NumberOfLines1(widths1, s1)));
            Console.WriteLine(String.Join(", ", NumberOfLines2(widths1, s1)));

            int[] widths2 = { 4, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };
            string s2 = "bbbcccdddaaa";
            Console.WriteLine(String.Join(", ", NumberOfLines1(widths2, s2)));
            Console.WriteLine(String.Join(", ", NumberOfLines2(widths2, s2)));
        }

        public static int[] NumberOfLines1(int[] widths, string s)
        {
            int[] result = new int[2];
            int currentLineWidth = 0;
            int lineCount = 0;

            for (int i = 0; i < s.Length; i++)
            {
                lineCount++;
                currentLineWidth = 0;

                while (i < s.Length && currentLineWidth + widths[s[i] - 'a'] <= 100)
                {
                    currentLineWidth += widths[s[i] - 'a'];
                    i++;
                }

                i--;
            }

            result[0] = lineCount;
            result[1] = currentLineWidth;

            return result;
        }

        public static int[] NumberOfLines2(int[] widths, string s)
        {
            int[] result = new int[2];

            for (int i = 0; i < s.Length; i++)
            {
                result[0]++;
                result[1] = 0;

                while (i < s.Length && result[1] + widths[s[i] - 'a'] <= 100)
                {
                    result[1] += widths[s[i] - 'a'];
                    i++;
                }

                i--;
            }

            return result;
        }
    }
}
