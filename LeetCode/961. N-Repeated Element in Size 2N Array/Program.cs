using System;
using System.Collections.Generic;

namespace _961._N_Repeated_Element_in_Size_2N_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3, 3 };
            Console.WriteLine(RepeatedNTimes(nums1));

            int[] nums2 = { 2, 1, 2, 5, 3, 2 };
            Console.WriteLine(RepeatedNTimes(nums2));

            int[] nums3 = { 5, 1, 5, 2, 5, 3, 5, 4 };
            Console.WriteLine(RepeatedNTimes(nums3));
        }

        public static int RepeatedNTimes(int[] nums)
        {
            Dictionary<int, int> occurances = new Dictionary<int, int>(nums.Length / 2 + 1);
            int nRepeatedElement = 0;

            foreach (var number in nums)
            {
                if (!occurances.ContainsKey(number))
                {
                    occurances.Add(number, 1);
                }
                else
                {
                    occurances[number]++;
                }

                if (occurances[number] == nums.Length / 2)
                {
                    nRepeatedElement = number;
                    break;
                }
            }

            return nRepeatedElement;
        }
    }
}
