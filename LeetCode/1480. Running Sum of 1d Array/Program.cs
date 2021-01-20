using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1480.Running_Sum_of_1d_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3, 4 };
            Console.WriteLine(string.Join(" ", RunningSum(nums1)));
            Console.WriteLine(string.Join(" ", RunningSum2(nums1)));

            int[] nums2 = { 1, 1, 1, 1, 1 };
            Console.WriteLine(string.Join(" ", RunningSum(nums2)));
            Console.WriteLine(string.Join(" ", RunningSum2(nums2)));

            int[] nums3 = { 3, 1, 2, 10, 1 };
            Console.WriteLine(string.Join(" ", RunningSum(nums3)));
            Console.WriteLine(string.Join(" ", RunningSum2(nums3)));

            Console.ReadKey();
        }

        public static int[] RunningSum(int[] nums)
        {
            int[] runningSum = new int[nums.Length];
            runningSum[0] = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                runningSum[i] = runningSum[i - 1] + nums[i];
            }

            return runningSum;
        }

        public static int[] RunningSum2(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] = nums[i - 1] + nums[i];
            }

            return nums;
        }
    }
}
