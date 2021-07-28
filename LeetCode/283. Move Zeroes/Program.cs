using System;
using System.Linq;

namespace _283._Move_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 0, 1, 0, 3, 12 };
            MoveZeroes1(nums1);
            Console.WriteLine(String.Join(", ", nums1));
            nums1 = new int[] { 0, 1, 0, 3, 12 };
            MoveZeroes2(nums1);
            Console.WriteLine(String.Join(", ", nums1));

            int[] nums2 = { 0 };
            MoveZeroes1(nums2);
            Console.WriteLine(String.Join(", ", nums2));
            nums2 = new int[] { 0 };
            MoveZeroes2(nums2);
            Console.WriteLine(String.Join(", ", nums2));
        }

        public static void MoveZeroes1(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    int index = i;
                    while (index > 0 && nums[index - 1] == 0)
                    {
                        int temp = nums[index];
                        nums[index] = nums[index - 1];
                        nums[index - 1] = temp;

                        index--;
                    }
                }
            }
        }

        public static void MoveZeroes2(int[] nums)
        {
            for (int current = 0, lastNonZeroIndex = 0; current < nums.Length; current++)
            {
                if (nums[current] != 0)
                {
                    int temp = nums[current];
                    nums[current] = nums[lastNonZeroIndex];
                    nums[lastNonZeroIndex] = temp;

                    lastNonZeroIndex++;
                }
            }
        }
    }
}
