using System;
using System.Collections.Generic;
using System.Linq;

namespace _1200._Minimum_Absolute_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 4, 2, 1, 3 };
            Print(MinimumAbsDifference1(arr1));
            Print(MinimumAbsDifference2(arr1));

            int[] arr2 = { 1, 3, 6, 10, 15 };
            Print(MinimumAbsDifference1(arr2));
            Print(MinimumAbsDifference2(arr2));

            int[] arr3 = { 3, 8, -10, 23, 19, -4, -14, 27 };
            Print(MinimumAbsDifference1(arr3));
            Print(MinimumAbsDifference2(arr3));
        }

        public static IList<IList<int>> MinimumAbsDifference1(int[] arr)
        {
            Dictionary<int, IList<IList<int>>> differences = new Dictionary<int, IList<IList<int>>>();
            int minimumDifference = int.MaxValue;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int absoluteDifference = Math.Abs(arr[i] - arr[j]);
                    int smaller = Math.Min(arr[i], arr[j]);
                    int bigger = Math.Max(arr[i], arr[j]);

                    if (differences.ContainsKey(absoluteDifference))
                    {
                        differences[absoluteDifference].Add(new List<int> { smaller, bigger });
                    }
                    else
                    {
                        differences.Add(absoluteDifference, new List<IList<int>> { new List<int> { smaller, bigger } });
                    }

                    if (minimumDifference > absoluteDifference)
                    {
                        minimumDifference = absoluteDifference;
                    }
                }
            }

            return differences[minimumDifference].OrderBy(x => x[0]).ToList();
        }

        private static IList<IList<int>> MinimumAbsDifference2(int[] arr)
        {
            IList<IList<int>> pairs = new List<IList<int>>();
            Array.Sort(arr);
            int minimumDifference = int.MaxValue;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int absoluteDifference = Math.Abs(arr[i] - arr[i + 1]);

                minimumDifference = Math.Min(absoluteDifference, minimumDifference);
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int absoluteDifference = Math.Abs(arr[i] - arr[i + 1]);

                if (absoluteDifference == minimumDifference)
                {
                    pairs.Add(new List<int> { arr[i], arr[i + 1] });
                }
            }

            return pairs;
        }

        private static void Print(IList<IList<int>> lists)
        {
            foreach (var list in lists)
            {
                Console.Write($"[{list[0]}, {list[1]}] ");
            }

            Console.WriteLine();
        }
    }
}
