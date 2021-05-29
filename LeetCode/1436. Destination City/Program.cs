using System;
using System.Collections.Generic;

namespace _1436._Destination_City
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<IList<string>> paths1 = new List<IList<string>> 
            { 
                new List<string> { "London","New York" },
                new List<string> { "New York","Lima" },
                new List<string> { "Lima","Sao Paulo" }
            };
            Console.WriteLine(DestCity1(paths1));
            Console.WriteLine(DestCity2(paths1));

            IList<IList<string>> paths2 = new List<IList<string>>
            {
                new List<string> { "B","C" },
                new List<string> { "D","B" },
                new List<string> { "C","A" }
            };
            Console.WriteLine(DestCity1(paths2));
            Console.WriteLine(DestCity2(paths2));

            IList<IList<string>> paths3 = new List<IList<string>>
            {
                new List<string> { "A","Z" }
            };
            Console.WriteLine(DestCity1(paths3));
            Console.WriteLine(DestCity2(paths3));
        }

        public static string DestCity1(IList<IList<string>> paths)
        {
            Dictionary<string, int> cities = new Dictionary<string, int>();

            foreach (var path in paths)
            {
                if (!cities.ContainsKey(path[0]))
                {
                    cities.Add(path[0], 1);
                }
                else
                {
                    cities[path[0]]++;
                }

                if (!cities.ContainsKey(path[1]))
                {
                    cities.Add(path[1], 1);
                }
                else
                {
                    cities[path[1]]++;
                }
            }

            foreach (var path in paths)
            {
                if (cities[path[1]] == 1)
                {
                    return path[1];
                }
            }

            return string.Empty;
        }

        public static string DestCity2(IList<IList<string>> paths)
        {
            HashSet<string> startCities = new HashSet<string>();

            foreach (var path in paths)
            {
                startCities.Add(path[0]);
            }

            foreach (var path in paths)
            {
                if (!startCities.Contains(path[1]))
                {
                    return path[1];
                }
            }

            return string.Empty;
        }
    }
}
