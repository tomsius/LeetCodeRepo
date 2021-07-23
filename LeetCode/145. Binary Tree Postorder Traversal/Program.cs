using System;
using System.Collections.Generic;
using System.Linq;

namespace _145._Binary_Tree_Postorder_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root1 = new TreeNode(1, null, new TreeNode(2, new TreeNode(3)));
            Console.WriteLine(String.Join(", ", PostorderTraversal(root1)));

            TreeNode root2 = null;
            Console.WriteLine(String.Join(", ", PostorderTraversal(root2)));

            TreeNode root3 = new TreeNode(1);
            Console.WriteLine(String.Join(", ", PostorderTraversal(root3)));

            TreeNode root4 = new TreeNode(1, new TreeNode(2));
            Console.WriteLine(String.Join(", ", PostorderTraversal(root4)));

            TreeNode root5 = new TreeNode(1, null, new TreeNode(2));
            Console.WriteLine(String.Join(", ", PostorderTraversal(root5)));
        }

        public static IList<int> PostorderTraversal(TreeNode root)
        {
            IList<int> values = new List<int>();

            PostorderRec(root, values);

            return values;
        }

        private static void PostorderRec(TreeNode node, IList<int> values)
        {
            if (node == null)
            {
                return;
            }

            PostorderRec(node.left, values);
            PostorderRec(node.right, values);

            values.Add(node.val);
        }
    }
}
