using System;
using System.Linq;

namespace _1103._Distribute_Candies_to_People
{
    class Program
    {
        static void Main(string[] args)
        {
            int candies1 = 7;
            int num_people1 = 4;
            Console.WriteLine(String.Join(", ", DistributeCandies1(candies1, num_people1)));
            Console.WriteLine(String.Join(", ", DistributeCandies2(candies1, num_people1)));

            int candies2 = 10;
            int num_people2 = 3;
            Console.WriteLine(String.Join(", ", DistributeCandies1(candies2, num_people2)));
            Console.WriteLine(String.Join(", ", DistributeCandies2(candies2, num_people2)));
        }

        public static int[] DistributeCandies1(int candies, int num_people)
        {
            int[] people = new int[num_people];
            int candiesToGive = 1;
            int personIndex = 0;

            while (candies - candiesToGive >= 0)
            {
                people[personIndex] += candiesToGive;
                candies -= candiesToGive;
                candiesToGive++;
                personIndex++;

                if (personIndex == num_people)
                {
                    personIndex = 0;
                }
            }

            people[personIndex] += candies;

            return people;
        }

        public static int[] DistributeCandies2(int candies, int num_people)
        {
            int[] people = new int[num_people];
            int candiesToGive = 1;

            while (candies - candiesToGive >= 0)
            {
                people[(candiesToGive - 1) % num_people] += candiesToGive;
                candies -= candiesToGive;
                candiesToGive++;
            }

            people[(candiesToGive - 1) % num_people] += candies;

            return people;
        }
    }
}
