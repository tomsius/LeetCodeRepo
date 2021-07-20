using System;

namespace _1446._Consecutive_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "leetcode";
            Console.WriteLine(MaxPower1(s1));
            Console.WriteLine(MaxPower2(s1));

            string s2 = "abbcccddddeeeeedcba";
            Console.WriteLine(MaxPower1(s2));
            Console.WriteLine(MaxPower2(s2));

            string s3 = "triplepillooooow";
            Console.WriteLine(MaxPower1(s3));
            Console.WriteLine(MaxPower2(s3));

            string s4 = "hooraaaaaaaaaaay";
            Console.WriteLine(MaxPower1(s4));
            Console.WriteLine(MaxPower2(s4));

            string s5 = "tourist";
            Console.WriteLine(MaxPower1(s5));
            Console.WriteLine(MaxPower2(s5));
        }

        public static int MaxPower1(string s)
        {
            int maxPower = 1;

            for (int i = 1; i < s.Length; i++)
            {
                int currentPower = 1;

                while (i < s.Length && s[i - 1] == s[i])
                {
                    currentPower++;
                    i++;
                }

                maxPower = Math.Max(maxPower, currentPower);
            }

            return maxPower;
        }

        public static int MaxPower2(string s)
        {
            int maxPower = 1;
            int currentPower = 1;

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i - 1] == s[i])
                {
                    currentPower++;
                }
                else
                {
                    maxPower = Math.Max(maxPower, currentPower);
                    currentPower = 1;
                }
            }

            return maxPower;
        }
    }
}
