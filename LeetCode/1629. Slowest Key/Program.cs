using System;

namespace _1629._Slowest_Key
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] releaseTimes1 = { 9, 29, 49, 50 };
            string keysPressed1 = "cbcd";
            Console.WriteLine(SlowestKey1(releaseTimes1, keysPressed1));
            Console.WriteLine(SlowestKey2(releaseTimes1, keysPressed1));

            int[] releaseTimes2 = { 12, 23, 36, 46, 62 };
            string keysPressed2 = "spuda";
            Console.WriteLine(SlowestKey1(releaseTimes2, keysPressed2));
            Console.WriteLine(SlowestKey2(releaseTimes2, keysPressed2));
        }

        public static char SlowestKey1(int[] releaseTimes, string keysPressed)
        {
            int longestDuration = releaseTimes[0];
            char slowestKey = keysPressed[0];

            for (int i = 1; i < releaseTimes.Length; i++)
            {
                if (releaseTimes[i] - releaseTimes[i - 1] > longestDuration)
                {
                    longestDuration = releaseTimes[i] - releaseTimes[i - 1];
                    slowestKey = keysPressed[i];
                }
                else if (releaseTimes[i] - releaseTimes[i - 1] == longestDuration && slowestKey < keysPressed[i])
                {
                    slowestKey = keysPressed[i];
                }
            }

            return slowestKey;
        }

        public static char SlowestKey2(int[] releaseTimes, string keysPressed)
        {
            int longestDuration = releaseTimes[0];
            char slowestKey = keysPressed[0];

            for (int i = 1; i < releaseTimes.Length; i++)
            {
                if ((releaseTimes[i] - releaseTimes[i - 1] > longestDuration) || (releaseTimes[i] - releaseTimes[i - 1] == longestDuration && slowestKey < keysPressed[i]))
                {
                    longestDuration = releaseTimes[i] - releaseTimes[i - 1];
                    slowestKey = keysPressed[i];
                }
            }

            return slowestKey;
        }
    }
}
