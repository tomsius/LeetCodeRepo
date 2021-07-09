using System;

namespace _1413._Minimum_Value_to_Get_Positive_Step_by_Step_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { -3, 2, -3, 4, 2 };
            Console.WriteLine(MinStartValue(nums1));

            int[] nums2 = { 1, 2 };
            Console.WriteLine(MinStartValue(nums2));

            int[] nums3 = { 1, -2, -3 };
            Console.WriteLine(MinStartValue(nums3));
        }

        public static int MinStartValue(int[] nums)
        {
            int minimumPositiveStartValue = 1;
            int sum = 0;

            foreach (var num in nums)
            {
                sum += num;

                if (sum < 0)
                {
                    int newPossibleValue = Math.Abs(sum) + 1;
                    minimumPositiveStartValue = Math.Max(minimumPositiveStartValue, newPossibleValue);
                }
            }

            return minimumPositiveStartValue;
        }
    }
}
