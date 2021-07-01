using System;
using System.Collections.Generic;

namespace _94._Binary_Tree_Inorder_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root1 = new TreeNode(1, null, new TreeNode(2, new TreeNode(3)));
            Console.WriteLine(String.Join(", ", InorderTraversal(root1)));

            TreeNode root2 = null;
            Console.WriteLine(String.Join(", ", InorderTraversal(root2)));

            TreeNode root3 = new TreeNode(1);
            Console.WriteLine(String.Join(", ", InorderTraversal(root3)));

            TreeNode root4 = new TreeNode(1, new TreeNode(2));
            Console.WriteLine(String.Join(", ", InorderTraversal(root4)));

            TreeNode root5 = new TreeNode(1, null, new TreeNode(2));
            Console.WriteLine(String.Join(", ", InorderTraversal(root5)));
        }

        public static IList<int> InorderTraversal(TreeNode root)
        {
            IList<int> values = new List<int>();

            InOrderTraverse(root, values);

            return values;
        }

        private static void InOrderTraverse(TreeNode root, IList<int> values)
        {
            if (root == null)
            {
                return;
            }

            InOrderTraverse(root.left, values);
            values.Add(root.val);
            InOrderTraverse(root.right, values);
        }
    }
}
