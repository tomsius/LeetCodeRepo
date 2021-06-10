using System;

namespace _1502._Can_Make_Arithmetic_Progression_From_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 3, 5, 1 };
            Console.WriteLine(CanMakeArithmeticProgression(arr1));

            int[] arr2 = { 1, 2, 4 };
            Console.WriteLine(CanMakeArithmeticProgression(arr2));
        }

        public static bool CanMakeArithmeticProgression(int[] arr)
        {
            Array.Sort(arr);

            int difference = arr[1] - arr[0];

            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i] - arr[i - 1] != difference)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
