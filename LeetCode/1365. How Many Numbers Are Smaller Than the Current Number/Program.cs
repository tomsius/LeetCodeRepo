using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1365.How_Many_Numbers_Are_Smaller_Than_the_Current_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 8, 1, 2, 2, 3 };
            Console.WriteLine(string.Join(", ", SmallerNumbersThanCurrent(nums1)));
            Console.WriteLine(string.Join(", ", SmallerNumbersThanCurrent2(nums1)));

            int[] nums2 = { 6, 5, 4, 8 };
            Console.WriteLine(string.Join(", ", SmallerNumbersThanCurrent(nums2)));
            Console.WriteLine(string.Join(", ", SmallerNumbersThanCurrent2(nums2)));

            int[] nums3 = { 7, 7, 7, 7 };
            Console.WriteLine(string.Join(", ", SmallerNumbersThanCurrent(nums3)));
            Console.WriteLine(string.Join(", ", SmallerNumbersThanCurrent2(nums3)));

            Console.ReadKey();
        }

        public static int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] output = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    if (nums[j] < nums[i])
                    {
                        output[i]++;
                    }
                }
            }

            return output;
        }

        public static int[] SmallerNumbersThanCurrent2(int[] nums)
        {
            int[] output = new int[nums.Length];
            int[] lower = new int[101];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j <= nums[i]; j++)
                {
                    lower[j]++;
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                output[i] = nums.Length - lower[nums[i]];
            }

            return output;
        }
    }
}
