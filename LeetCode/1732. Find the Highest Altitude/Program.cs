using System;

namespace _1732._Find_the_Highest_Altitude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] gain1 = { -5, 1, 5, 0, -7 };
            Console.WriteLine(LargestAltitude1(gain1));
            Console.WriteLine(LargestAltitude2(gain1));

            int[] gain2 = { -4, -3, -2, -1, 4, 3, 2 };
            Console.WriteLine(LargestAltitude1(gain2));
            Console.WriteLine(LargestAltitude2(gain2));
        }

        public static int LargestAltitude1(int[] gain)
        {
            int[] altitudes = new int[gain.Length + 1];
            altitudes[0] = 0;
            int highestAltitude = altitudes[0];

            for (int i = 0; i < gain.Length; i++)
            {
                altitudes[i + 1] = altitudes[i] + gain[i];

                if (altitudes[i + 1] > highestAltitude)
                {
                    highestAltitude = altitudes[i + 1];
                }
            }

            return highestAltitude;
        }

        public static int LargestAltitude2(int[] gain)
        {
            int highestAltitude = 0;
            int currentAltitude = 0;

            for (int i = 0; i < gain.Length; i++)
            {
                currentAltitude += gain[i];

                if (currentAltitude > highestAltitude)
                {
                    highestAltitude = currentAltitude;
                }
            }

            return highestAltitude;
        }
    }
}
