using System;

namespace _495._Teemo_Attacking
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] timeSeries1 = { 1, 4 };
            int duration1 = 2;
            Console.WriteLine(FindPoisonedDuration1(timeSeries1, duration1));
            Console.WriteLine(FindPoisonedDuration2(timeSeries1, duration1));

            int[] timeSeries2 = { 1, 2 };
            int duration2 = 2;
            Console.WriteLine(FindPoisonedDuration1(timeSeries2, duration2));
            Console.WriteLine(FindPoisonedDuration2(timeSeries2, duration2));
        }

        public static int FindPoisonedDuration1(int[] timeSeries, int duration)
        {
            int totalPoisonedDuration = 0;

            for (int i = 1; i < timeSeries.Length; i++)
            {
                if (timeSeries[i] - timeSeries[i - 1] >= duration)
                {
                    totalPoisonedDuration += duration;
                }
                else
                {
                    totalPoisonedDuration += timeSeries[i] - timeSeries[i - 1];
                }
            }

            totalPoisonedDuration += duration;

            return totalPoisonedDuration;
        }

        public static int FindPoisonedDuration2(int[] timeSeries, int duration)
        {
            int totalPoisonedDuration = 0;

            for (int i = 1; i < timeSeries.Length; i++)
            {
                totalPoisonedDuration += Math.Min(timeSeries[i] - timeSeries[i - 1], duration);
            }

            totalPoisonedDuration += duration;

            return totalPoisonedDuration;
        }
    }
}
