using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Two_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 2, 7, 11, 15 };
            int target1 = 9;
            Console.WriteLine(String.Join(", ", TwoSum1(nums1, target1)));

            int[] nums2 = { 3, 2, 4 };
            int target2 = 6;
            Console.WriteLine(String.Join(", ", TwoSum1(nums2, target2)));

            int[] nums3 = { 3, 3 };
            int target3 = 6;
            Console.WriteLine(String.Join(", ", TwoSum1(nums3, target3)));
        }

        public static int[] TwoSum1(int[] nums, int target)
        {
            Dictionary<int, int> indicesByNumber = new Dictionary<int, int>(nums.Length);
            int[] indices = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                int number = nums[i];
                int neededNumber = target - number;

                if (indicesByNumber.ContainsKey(neededNumber))
                {
                    indices[0] = i;
                    indices[1] = indicesByNumber[neededNumber];

                    break;
                }
                else
                {
                    indicesByNumber.Add(number, i);
                }
            }

            return indices;
        }
    }
}
