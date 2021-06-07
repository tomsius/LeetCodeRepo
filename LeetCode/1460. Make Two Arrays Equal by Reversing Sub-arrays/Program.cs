using System;
using System.Collections.Generic;

namespace _1460._Make_Two_Arrays_Equal_by_Reversing_Sub_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] target1 = {1, 2, 3, 4};
            int[] arr1 = { 2, 4, 1, 3 };
            Console.WriteLine(CanBeEqual1(target1, arr1));
            Console.WriteLine(CanBeEqual2(target1, arr1));

            int[] target2 = { 7 };
            int[] arr2 = { 7 };
            Console.WriteLine(CanBeEqual1(target2, arr2));
            Console.WriteLine(CanBeEqual2(target2, arr2));

            int[] target3 = { 1, 12 };
            int[] arr3 = { 12, 1 };
            Console.WriteLine(CanBeEqual1(target3, arr3));
            Console.WriteLine(CanBeEqual2(target3, arr3));

            int[] target4 = { 3, 7, 9 };
            int[] arr4 = { 3, 7, 11 };
            Console.WriteLine(CanBeEqual1(target4, arr4));
            Console.WriteLine(CanBeEqual2(target4, arr4));

            int[] target5 = { 1, 1, 1, 1, 1 };
            int[] arr5 = { 1, 1, 1, 1, 1 };
            Console.WriteLine(CanBeEqual1(target5, arr5));
            Console.WriteLine(CanBeEqual2(target5, arr5));

            int[] target6 = { 1, 2, 2, 3 };
            int[] arr6 = { 1, 1, 2, 3 };
            Console.WriteLine(CanBeEqual1(target6, arr6));
            Console.WriteLine(CanBeEqual2(target6, arr6));
        }

        public static bool CanBeEqual1(int[] target, int[] arr)
        {
            Dictionary<int, int> targetDigits = new Dictionary<int, int>(target.Length);
            Dictionary<int, int> arrDigits = new Dictionary<int, int>(target.Length);

            foreach (var digit in target)
            {
                if (targetDigits.ContainsKey(digit))
                {
                    targetDigits[digit]++;
                }
                else
                {
                    targetDigits[digit] = 1;
                }
            }

            foreach (var digit in arr)
            {
                if (arrDigits.ContainsKey(digit))
                {
                    arrDigits[digit]++;
                }
                else
                {
                    arrDigits[digit] = 1;
                }
            }

            foreach (var kvp in arrDigits)
            {
                if (!targetDigits.ContainsKey(kvp.Key) || targetDigits[kvp.Key] != arrDigits[kvp.Key])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool CanBeEqual2(int[] target, int[] arr)
        {
            Dictionary<int, int> targetDigits = new Dictionary<int, int>(target.Length);

            foreach (var digit in target)
            {
                if (targetDigits.ContainsKey(digit))
                {
                    targetDigits[digit]++;
                }
                else
                {
                    targetDigits[digit] = 1;
                }
            }

            foreach (var digit in arr)
            {
                if (targetDigits.ContainsKey(digit))
                {
                    targetDigits[digit]--;

                    if (targetDigits[digit] < 0)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
