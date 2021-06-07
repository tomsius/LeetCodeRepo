using System;
using System.Collections.Generic;

namespace _1207._Unique_Number_of_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 2, 1, 1, 3 };
            Console.WriteLine(UniqueOccurrences(arr1));

            int[] arr2 = { 1, 2 };
            Console.WriteLine(UniqueOccurrences(arr2));

            int[] arr3 = { -3, 0, 1, -3, 1, 1, 1, -3, 10, 0 };
            Console.WriteLine(UniqueOccurrences(arr3));
        }

        public static bool UniqueOccurrences(int[] arr)
        {
            Dictionary<int, int> occurances = new Dictionary<int, int>(arr.Length);
            HashSet<int> uniqueOccurances = new HashSet<int>(arr.Length);

            foreach (var digit in arr)
            {
                if (occurances.ContainsKey(digit))
                {
                    occurances[digit]++;
                }
                else
                {
                    occurances[digit] = 1;
                }
            }

            foreach (var kvp in occurances)
            {
                if (uniqueOccurances.Contains(kvp.Value))
                {
                    return false;
                }
                else
                {
                    uniqueOccurances.Add(kvp.Value);
                }
            }

            return true;
        }
    }
}
