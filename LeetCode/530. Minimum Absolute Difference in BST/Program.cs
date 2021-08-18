using System;

namespace _530._Minimum_Absolute_Difference_in_BST
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root1 = new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(6));
            Console.WriteLine(GetMinimumDifference(root1));

            TreeNode root2 = new TreeNode(1, new TreeNode(0), new TreeNode(48, new TreeNode(12), new TreeNode(49)));
            Console.WriteLine(GetMinimumDifference(root2));

            TreeNode root3 = new TreeNode(1, null, new TreeNode(3, new TreeNode(2)));
            Console.WriteLine(GetMinimumDifference(root3));
        }

        private static TreeNode prev;
        private static int minimumDifference;

        public static int GetMinimumDifference(TreeNode root)
        {
            prev = null;
            minimumDifference = int.MaxValue;

            InOrder(root);

            return minimumDifference;
        }

        private static void InOrder(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            InOrder(node.left);

            if (prev != null)
            {
                minimumDifference = Math.Min(minimumDifference, node.val - prev.val);
            }

            prev = node;

            InOrder(node.right);
        }
    }
}
