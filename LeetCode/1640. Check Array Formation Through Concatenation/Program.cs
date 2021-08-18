using System;
using System.Collections.Generic;

namespace _1640._Check_Array_Formation_Through_Concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 85 };
            int[][] pieces1 = new int[][]
            {
                new int[] { 85 }
            };
            Console.WriteLine(CanFormArray(arr1, pieces1));

            int[] arr2 = { 15, 88 };
            int[][] pieces2 = new int[][]
            {
                new int[] { 88 },
                new int[] { 15 }
            };
            Console.WriteLine(CanFormArray(arr2, pieces2));

            int[] arr3 = { 49, 18, 16 };
            int[][] pieces3 = new int[][]
            {
                new int[] { 16, 18, 49 }
            };
            Console.WriteLine(CanFormArray(arr3, pieces3));

            int[] arr4 = { 91, 4, 64, 78 };
            int[][] pieces4 = new int[][]
            {
                new int[] { 78 },
                new int[] { 4, 64 },
                new int[] { 91 }
            };
            Console.WriteLine(CanFormArray(arr4, pieces4));

            int[] arr5 = { 1, 3, 5, 7 };
            int[][] pieces5 = new int[][]
            {
                new int[] { 2, 4, 6, 8 }
            };
            Console.WriteLine(CanFormArray(arr5, pieces5));
        }

        public static bool CanFormArray(int[] arr, int[][] pieces)
        {
            Dictionary<int, int> indicesByStartValue = new Dictionary<int, int>(pieces.Length);

            for (int i = 0; i < pieces.Length; i++)
            {
                indicesByStartValue.Add(pieces[i][0], i);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                int startValue = arr[i];

                if (indicesByStartValue.ContainsKey(startValue))
                {
                    int pieceIndex = indicesByStartValue[startValue];

                    foreach (var pieceValue in pieces[pieceIndex])
                    {
                        if (arr[i] != pieceValue)
                        {
                            return false;
                        }

                        i++;
                    }
                }
                else
                {
                    return false;
                }

                i--;
            }

            return true;
        }
    }
}
