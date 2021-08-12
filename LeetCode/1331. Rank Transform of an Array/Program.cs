using System;
using System.Collections.Generic;
using System.Linq;

namespace _1331._Rank_Transform_of_an_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 40, 10, 20, 30 };
            Console.WriteLine(String.Join(", ", ArrayRankTransform1(arr1)));
            Console.WriteLine(String.Join(", ", ArrayRankTransform2(arr1)));

            int[] arr2 = { 100, 100, 100 };
            Console.WriteLine(String.Join(", ", ArrayRankTransform1(arr2)));
            Console.WriteLine(String.Join(", ", ArrayRankTransform2(arr2)));

            int[] arr3 = { 37, 12, 28, 9, 100, 56, 80, 5, 12 };
            Console.WriteLine(String.Join(", ", ArrayRankTransform1(arr3)));
            Console.WriteLine(String.Join(", ", ArrayRankTransform2(arr3)));
        }

        public static int[] ArrayRankTransform1(int[] arr)
        {
            HashSet<int> uniqueValues = new HashSet<int>(arr);
            int[] sortedArr = uniqueValues.OrderBy(x => x).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                int rank = 0;

                while (rank < sortedArr.Length && sortedArr[rank] != arr[i])
                {
                    rank++;
                }

                arr[i] = rank + 1;
            }

            return arr;
        }

        public static int[] ArrayRankTransform2(int[] arr)
        {
            int[] sortedArr = new int[arr.Length];
            Array.Copy(arr, sortedArr, arr.Length);
            Array.Sort(sortedArr);

            Dictionary<int, int> ranks = new Dictionary<int, int>(arr.Length);
            int rank = 1;

            foreach (var number in sortedArr)
            {
                if (!ranks.ContainsKey(number))
                {
                    ranks.Add(number, rank);
                    rank++;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = ranks[arr[i]];
            }

            return arr;
        }
    }
}
