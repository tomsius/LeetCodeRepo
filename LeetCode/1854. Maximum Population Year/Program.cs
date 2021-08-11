using System;

namespace _1854._Maximum_Population_Year
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] logs1 = new int[][]
            {
                new int[] { 1993, 1999 },
                new int[] { 2000, 2010 }
            };
            Console.WriteLine(MaximumPopulation1(logs1));
            Console.WriteLine(MaximumPopulation2(logs1));

            int[][] logs2 = new int[][]
            {
                new int[] { 1950, 1961 },
                new int[] { 1960, 1971 },
                new int[] { 1970, 1981 }
            };
            Console.WriteLine(MaximumPopulation1(logs2));
            Console.WriteLine(MaximumPopulation2(logs2));
        }

        public static int MaximumPopulation1(int[][] logs)
        {
            int maxPopulationCount = 0;
            int earliestYear = 1950;

            for (int year = 1950; year <= 2050; year++)
            {
                int populationCount = 0;

                foreach (var dates in logs)
                {
                    if (dates[0] <= year && dates[1] > year)
                    {
                        populationCount++;
                    }
                }

                if (populationCount > maxPopulationCount)
                {
                    maxPopulationCount = populationCount;
                    earliestYear = year;
                }
            }

            return earliestYear;
        }

        public static int MaximumPopulation2(int[][] logs)
        {
            int[] years = new int[101];

            foreach (var dates in logs)
            {
                years[dates[0] - 1950]++;
                years[dates[1] - 1950]--;
            }

            int currentPopulation = 0;
            int maximumPopulation = 0;
            int earliestYear = 0;

            for (int year = 1950; year <= 2050; year++)
            {
                currentPopulation += years[year - 1950];

                if (currentPopulation > maximumPopulation)
                {
                    maximumPopulation = currentPopulation;
                    earliestYear = year;
                }
            }

            return earliestYear;
        }
    }
}
