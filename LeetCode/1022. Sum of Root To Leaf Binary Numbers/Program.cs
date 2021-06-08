using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1022._Sum_of_Root_To_Leaf_Binary_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root1 = new TreeNode(1, new TreeNode(0, new TreeNode(0), new TreeNode(1)), new TreeNode(1, new TreeNode(0), new TreeNode(1)));
            Console.WriteLine(SumRootToLeaf(root1));

            TreeNode root2 = new TreeNode(0);
            Console.WriteLine(SumRootToLeaf(root2));

            TreeNode root3 = new TreeNode(1);
            Console.WriteLine(SumRootToLeaf(root3));

            TreeNode root4 = new TreeNode(1, new TreeNode(1));
            Console.WriteLine(SumRootToLeaf(root4));
        }

        public static int SumRootToLeaf(TreeNode root)
        {
            List<int> integers = new List<int>();
            PreOrderTraversal(root, integers, new StringBuilder());

            return integers.Sum(x => x);
        }

        private static void PreOrderTraversal(TreeNode root, List<int> integers, StringBuilder sb)
        {
            if (root == null)
            {
                return;
            }

            sb.Append(root.val);

            if (root.left == null && root.right == null)
            {
                int integer = Convert.ToInt32(sb.ToString(), 2);
                integers.Add(integer);

                sb.Remove(sb.Length - 1, 1);
            }
            else
            {
                PreOrderTraversal(root.left, integers, sb);
                PreOrderTraversal(root.right, integers, sb);
                sb.Remove(sb.Length - 1, 1);
            }
        }
    }
}
