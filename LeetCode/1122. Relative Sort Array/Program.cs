using System;
using System.Collections.Generic;

namespace _1122._Relative_Sort_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 2, 3, 1, 3, 2, 4, 6, 7, 9, 2, 19 };
            int[] arr2 = { 2, 1, 4, 3, 9, 6 };
            Console.WriteLine(String.Join(", ", RelativeSortArray(arr1, arr2)));
        }

        public static int[] RelativeSortArray(int[] arr1, int[] arr2)
        {
            List<int> sortedArray = new List<int>(arr1.Length);
            List<int> array = new List<int>(arr1);

            foreach (var number in arr2)
            {
                var numbersToInsert = array.FindAll(x => x == number);
                array.RemoveAll(x => x == number);
                sortedArray.AddRange(numbersToInsert);
            }

            array.Sort();
            sortedArray.AddRange(array);

            return sortedArray.ToArray();
        }
    }
}
