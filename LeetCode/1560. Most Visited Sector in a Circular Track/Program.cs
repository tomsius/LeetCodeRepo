using System;
using System.Collections.Generic;
using System.Linq;

namespace _1560._Most_Visited_Sector_in_a_Circular_Track
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 4;
            int[] rounds1 = { 1, 3, 1, 2 };
            Console.WriteLine(String.Join(", ", MostVisited(n1, rounds1)));

            int n2 = 2;
            int[] rounds2 = { 2, 1, 2, 1, 2, 1, 2, 1, 2 };
            Console.WriteLine(String.Join(", ", MostVisited(n2, rounds2)));

            int n3 = 7;
            int[] rounds3 = { 1, 3, 5, 7 };
            Console.WriteLine(String.Join(", ", MostVisited(n3, rounds3)));

            int n4 = 3;
            int[] rounds4 = { 2, 1, 2, 1, 3, 2, 3, 1, 2, 3, 1, 3, 1, 2, 3, 1, 3, 2, 3, 2, 1, 2, 3, 1, 3 };
            Console.WriteLine(String.Join(", ", MostVisited(n4, rounds4)));
        }

        public static IList<int> MostVisited(int n, int[] rounds)
        {
            int[] visits = new int[n];
            visits[rounds[0] - 1] = 1;
            int maxVisits = 1;
            int sector = rounds[0] < n ? rounds[0] : 0;

            for (int i = 1; i < rounds.Length; i++)
            {
                int start = rounds[i - 1];
                int end = rounds[i];

                while (start != end)
                {
                    visits[sector]++;

                    if (maxVisits < visits[sector])
                    {
                        maxVisits = visits[sector];
                    }

                    sector++;

                    if (sector == n)
                    {
                        sector = 0;
                    }

                    start = start == n ? 1 : start + 1;
                }
            }

            IList<int> mostVisitedSectors = new List<int>(n);

            for (int i = 0; i < visits.Length; i++)
            {
                if (visits[i] == maxVisits)
                {
                    mostVisitedSectors.Add(i + 1);
                }
            }

            return mostVisitedSectors;
        }
    }
}
