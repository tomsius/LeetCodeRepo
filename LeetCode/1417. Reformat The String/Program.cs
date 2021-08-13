using System;
using System.Linq;
using System.Text;

namespace _1417._Reformat_The_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "a0b1c2";
            Console.WriteLine(Reformat1(s1));
            Console.WriteLine(Reformat2(s1));
            Console.WriteLine(Reformat3(s1));

            string s2 = "leetcode";
            Console.WriteLine(Reformat1(s2));
            Console.WriteLine(Reformat2(s2));
            Console.WriteLine(Reformat3(s2));

            string s3 = "1229857369";
            Console.WriteLine(Reformat1(s3));
            Console.WriteLine(Reformat2(s3));
            Console.WriteLine(Reformat3(s3));

            string s4 = "covid2019";
            Console.WriteLine(Reformat1(s4));
            Console.WriteLine(Reformat2(s4));
            Console.WriteLine(Reformat3(s4));

            string s5 = "ab123";
            Console.WriteLine(Reformat1(s5));
            Console.WriteLine(Reformat2(s5));
            Console.WriteLine(Reformat3(s5));
        }

        public static string Reformat1(string s)
        {
            int digitCount = CountDigits(s);
            int letterCount = CountLetters(s);

            if (Math.Abs(digitCount - letterCount) > 1)
            {
                return "";
            }

            StringBuilder sb = new StringBuilder();
            s = new string(s.ToCharArray().OrderBy(x => x).ToArray());

            int digitPointer = 0;
            int letterPointer = s.Length - 1;
            bool shouldDigitBeAppended = digitCount >= letterCount;

            while (digitPointer <= letterPointer)
            {
                if (shouldDigitBeAppended)
                {
                    sb.Append(s[digitPointer]);
                    digitPointer++;
                }
                else
                {
                    sb.Append(s[letterPointer]);
                    letterPointer--;
                }

                shouldDigitBeAppended = !shouldDigitBeAppended;
            }

            return sb.ToString();
        }

        private static int CountDigits(string s)
        {
            return CountByFlag(s, true);
        }

        private static int CountLetters(string s)
        {
            return CountByFlag(s, false);
        }

        private static int CountByFlag(string s, bool isCountingDigits)
        {
            int total = 0;

            foreach (var character in s)
            {
                if (isCountingDigits && char.IsDigit(character))
                {
                    total++;
                }
                
                if (!isCountingDigits && char.IsLetter(character))
                {
                    total++;
                }
            }

            return total;
        }

        public static string Reformat2(string s)
        {
            int digitCount = 0;
            int letterCount = 0;

            foreach (var character in s)
            {
                if (char.IsDigit(character))
                {
                    digitCount++;
                }
                else
                {
                    letterCount++;
                }
            }

            if (Math.Abs(digitCount - letterCount) > 1)
            {
                return "";
            }

            StringBuilder sb = new StringBuilder();
            s = new string(s.ToCharArray().OrderBy(x => x).ToArray());

            int digitPointer = 0;
            int letterPointer = s.Length - 1;
            bool shouldDigitBeAppended = digitCount >= letterCount;

            while (digitPointer <= letterPointer)
            {
                if (shouldDigitBeAppended)
                {
                    sb.Append(s[digitPointer]);
                    digitPointer++;
                }
                else
                {
                    sb.Append(s[letterPointer]);
                    letterPointer--;
                }

                shouldDigitBeAppended = !shouldDigitBeAppended;
            }

            return sb.ToString();
        }

        public static string Reformat3(string s)
        {
            int digitCount = 0;
            int letterCount = 0;

            foreach (var character in s)
            {
                if (char.IsDigit(character))
                {
                    digitCount++;
                }
                else
                {
                    letterCount++;
                }
            }

            if (Math.Abs(digitCount - letterCount) > 1)
            {
                return "";
            }

            StringBuilder sb = new StringBuilder();

            int digitPointer = 0;
            int letterPointer = 0;
            bool shouldDigitBeAppended = digitCount >= letterCount;

            while (sb.Length != s.Length)
            {
                if (shouldDigitBeAppended)
                {
                    while (digitPointer < s.Length && !char.IsDigit(s[digitPointer]))
                    {
                        digitPointer++;
                    }

                    sb.Append(s[digitPointer]);
                    digitPointer++;
                }
                else
                {
                    while (letterPointer < s.Length && !char.IsLetter(s[letterPointer]))
                    {
                        letterPointer++;
                    }

                    sb.Append(s[letterPointer]);
                    letterPointer++;
                }

                shouldDigitBeAppended = !shouldDigitBeAppended;
            }

            return sb.ToString();
        }
    }
}
