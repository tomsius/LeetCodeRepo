using System;

namespace _171._Excel_Sheet_Column_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string columnTitle1 = "A";
            Console.WriteLine(TitleToNumber1(columnTitle1));
            Console.WriteLine(TitleToNumber2(columnTitle1));

            string columnTitle2 = "AB";
            Console.WriteLine(TitleToNumber1(columnTitle2));
            Console.WriteLine(TitleToNumber2(columnTitle2));

            string columnTitle3 = "ZY";
            Console.WriteLine(TitleToNumber1(columnTitle3));
            Console.WriteLine(TitleToNumber2(columnTitle3));

            string columnTitle4 = "FXSHRXW";
            Console.WriteLine(TitleToNumber1(columnTitle4));
            Console.WriteLine(TitleToNumber2(columnTitle4));
        }

        public static int TitleToNumber1(string columnTitle)
        {
            int columnNumber = 0;

            for (int i = columnTitle.Length - 1; i >= 0; i--)
            {
                int charValue = columnTitle[i] - 'A' + 1;

                columnNumber += charValue * (int)Math.Pow(26, columnTitle.Length - i - 1);
            }

            return columnNumber;
        }

        public static int TitleToNumber2(string columnTitle)
        {
            int columnNumber = 0;

            for (int i = 0; i < columnTitle.Length; i++)
            {
                int charValue = columnTitle[i] - 'A' + 1;

                columnNumber = columnNumber * 26 + charValue;
            }

            return columnNumber;
        }
    }
}
