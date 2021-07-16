using System;
using System.Collections.Generic;

namespace _108._Convert_Sorted_Array_to_Binary_Search_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { -10, -3, 0, 5, 9 };
            PrintInorder(SortedArrayToBST1(nums1));
            Console.WriteLine();
            PrintInorder(SortedArrayToBST2(nums1));
            Console.WriteLine();

            int[] nums2 = { 1, 3 };
            PrintInorder(SortedArrayToBST1(nums2));
            Console.WriteLine();
            PrintInorder(SortedArrayToBST2(nums2));
            Console.WriteLine();

            int[] nums3 = { -1, 0, 1, 2 };
            PrintInorder(SortedArrayToBST1(nums3));
            Console.WriteLine();
            PrintInorder(SortedArrayToBST2(nums3));
            Console.WriteLine();

            int[] nums4 = { 0 };
            PrintInorder(SortedArrayToBST1(nums4));
            Console.WriteLine();
            PrintInorder(SortedArrayToBST2(nums4));
            Console.WriteLine();

            int[] nums5 = { 0, 1, 2, 3, 4, 5, 6, 7 };
            PrintInorder(SortedArrayToBST1(nums5));
            Console.WriteLine();
            PrintInorder(SortedArrayToBST2(nums5));
        }

        public static TreeNode SortedArrayToBST1(int[] nums)
        {
            return ToBST(nums, 0, nums.Length - 1);
        }

        private static TreeNode ToBST(int[] nums, int left, int right)
        {
            if (left > right)
            {
                return null;
            }

            int middle = left + (right - left) / 2;

            return new TreeNode(nums[middle], ToBST(nums, left, middle -1), ToBST(nums, middle +1, right));
        }

        public static TreeNode SortedArrayToBST2(int[] nums)
        {
            Stack<(TreeNode, int, int)> stack = new Stack<(TreeNode, int, int)>();
            TreeNode root = new TreeNode(-1);
            stack.Push((root, 0, nums.Length));

            while (stack.Count != 0)
            {
                var (node, left, right) = stack.Pop();
                int mid = left + (right - left) / 2;
                node.val = nums[mid];

                if (left < mid)
                {
                    stack.Push((node.left = new TreeNode(-1), left, mid));
                }
                    
                if (mid + 1 < right)
                {
                    stack.Push((node.right = new TreeNode(-1), mid + 1, right));
                }
            }

            return root;
        }

        private static void PrintInorder(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            PrintInorder(node.left);
            Console.WriteLine(node.val);
            PrintInorder(node.right);
        }
    }
}
