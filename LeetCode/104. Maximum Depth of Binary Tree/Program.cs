using System;

namespace _104._Maximum_Depth_of_Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root1 = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));
            Console.WriteLine(MaxDepth(root1));

            TreeNode root2 = new TreeNode(1, null, new TreeNode(2));
            Console.WriteLine(MaxDepth(root2));

            TreeNode root3 = null;
            Console.WriteLine(MaxDepth(root3));

            TreeNode root4 = new TreeNode(0);
            Console.WriteLine(MaxDepth(root4));
        }

        public static int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            int leftSubtreeDepth = MaxDepth(root.left);
            int rightSubtreeDepth = MaxDepth(root.right);

            return Math.Max(leftSubtreeDepth, rightSubtreeDepth) + 1;
        }
    }
}
