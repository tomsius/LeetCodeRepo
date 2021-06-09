using System;

namespace _922._Sort_Array_By_Parity_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 4, 2, 5, 7 };
            Console.WriteLine(String.Join(", ", SortArrayByParityII(nums1)));

            int[] nums2 = { 2, 3 };
            Console.WriteLine(String.Join(", ", SortArrayByParityII(nums2)));

            int[] nums3 = { 4, 1, 2, 2, 3, 1, 4, 0, 1, 1 };
            Console.WriteLine(String.Join(", ", SortArrayByParityII(nums3)));

            int[] nums4 = { 3, 0, 4, 0, 2, 1, 3, 1, 3, 4 };
            Console.WriteLine(String.Join(", ", SortArrayByParityII(nums4)));
        }

        public static int[] SortArrayByParityII(int[] nums)
        {
            int temp;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if ((i % 2 == 0 && nums[i] % 2 != 0) || (i % 2 == 1 && nums[i] % 2 != 1))
                {
                    int newIndex = i + 1;
                    int parity = i % 2;

                    while (nums[newIndex] % 2 != parity)
                    {
                        newIndex++;
                    }

                    temp = nums[i];
                    nums[i] = nums[newIndex];
                    nums[newIndex] = temp;
                }
            }

            return nums;
        }
    }
}
