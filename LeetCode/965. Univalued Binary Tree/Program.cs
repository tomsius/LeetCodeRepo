using System;
using System.Collections.Generic;

namespace _965._Univalued_Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root1 = new TreeNode(1, new TreeNode(1, new TreeNode(1), new TreeNode(1)), new TreeNode(1, null, new TreeNode(1)));
            Console.WriteLine(IsUnivalTree1(root1));
            Console.WriteLine(IsUnivalTree2(root1));

            TreeNode root2 = new TreeNode(2, new TreeNode(2, new TreeNode(5), new TreeNode(2)), new TreeNode(2));
            Console.WriteLine(IsUnivalTree1(root2));
            Console.WriteLine(IsUnivalTree2(root2));
        }

        public static bool IsUnivalTree1(TreeNode root)
        {
            List<int> values = new List<int>();
            InOrderTraverse(root, values);

            for (int i = 0; i < values.Count - 1; i++)
            {
                if (values[i] != values[i + 1])
                {
                    return false;
                }
            }

            return true;
        }

        private static void InOrderTraverse(TreeNode root, List<int> values)
        {
            if (root == null)
            {
                return;
            }

            InOrderTraverse(root.left, values);
            values.Add(root.val);
            InOrderTraverse(root.right, values);
        }

        public static bool IsUnivalTree2(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            if (root.left != null && root.val != root.left.val)
            {
                return false;
            }

            if (root.right != null && root.val != root.right.val)
            { 
                return false;
            }

            return IsUnivalTree2(root.left) && IsUnivalTree2(root.right);
        }
    }
}
