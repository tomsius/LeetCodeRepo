using System;
using System.Collections.Generic;

namespace _496._Next_Greater_Element_I
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums11 = { 4, 1, 2 };
            int[] nums21 = { 1, 3, 4, 2 };
            Console.WriteLine(String.Join(", ", NextGreaterElement1(nums11, nums21)));
            Console.WriteLine(String.Join(", ", NextGreaterElement2(nums11, nums21)));

            int[] nums12 = { 2, 4 };
            int[] nums22 = { 1, 2, 3, 4 };
            Console.WriteLine(String.Join(", ", NextGreaterElement1(nums12, nums22)));
            Console.WriteLine(String.Join(", ", NextGreaterElement2(nums12, nums22)));
        }

        public static int[] NextGreaterElement1(int[] nums1, int[] nums2)
        {
            int[] ans = new int[nums1.Length];

            for (int i = 0; i < nums1.Length; i++)
            {
                ans[i] = FindNextGreater(nums1[i], nums2);
            }

            return ans;
        }

        private static int FindNextGreater(int value, int[] nums)
        {
            int index = 0;
            while (nums[index] != value)
            {
                index++;
            }

            for (int i = index; i < nums.Length; i++)
            {
                if (nums[i] > value)
                {
                    return nums[i];
                }
            }

            return -1;
        }

        public static int[] NextGreaterElement2(int[] nums1, int[] nums2)
        {
            int[] ans = new int[nums1.Length];
            Dictionary<int, int> nextGreaterElement = new Dictionary<int, int>(nums2.Length);
            Stack<int> cache = new Stack<int>(nums2.Length);

            for (int i = nums2.Length - 1; i >= 0; i--)
            {
                while (cache.Count > 0 && cache.Peek() <= nums2[i])
                {
                    cache.Pop();
                }

                int greaterElement = cache.Count == 0 ? -1 : cache.Peek();
                nextGreaterElement.Add(nums2[i], greaterElement);
                cache.Push(nums2[i]);
            }

            for (int i = 0; i < nums1.Length; i++)
            {
                ans[i] = nextGreaterElement[nums1[i]];
            }

            return ans;
        }
    }
}
