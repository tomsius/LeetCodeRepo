using System;
using System.Collections.Generic;
using System.Linq;

namespace _448._Find_All_Numbers_Disappeared_in_an_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 4, 3, 2, 7, 8, 2, 3, 1 };
            Console.WriteLine(String.Join(", ", FindDisappearedNumbers1(nums1)));
            Console.WriteLine(String.Join(", ", FindDisappearedNumbers2(nums1)));

            int[] nums2 = { 1, 1 };
            Console.WriteLine(String.Join(", ", FindDisappearedNumbers1(nums2)));
            Console.WriteLine(String.Join(", ", FindDisappearedNumbers2(nums2)));
        }

        public static IList<int> FindDisappearedNumbers1(int[] nums)
        {
            IList<int> disappearedNumbers = new List<int>(nums.Length);
            int[] occurances = new int[nums.Length];

            foreach (var num in nums)
            {
                occurances[num - 1]++;
            }

            for (int i = 0; i < occurances.Length; i++)
            {
                if (occurances[i] == 0)
                {
                    disappearedNumbers.Add(i + 1);
                }
            }

            return disappearedNumbers;
        }

        public static IList<int> FindDisappearedNumbers2(int[] nums)
        {
            IList<int> disappearedNumbers = new List<int>(nums.Length);

            for (int i = 0; i < nums.Length; i++)
            {
                int index = Math.Abs(nums[i]) - 1;

                if (nums[index] > 0)
                {
                    nums[index] = -1 * nums[index];
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    disappearedNumbers.Add(i + 1);
                }
            }

            return disappearedNumbers;
        }
    }
}
