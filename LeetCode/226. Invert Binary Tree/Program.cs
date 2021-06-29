using System;

namespace _226._Invert_Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root1 = new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(7, new TreeNode(6), new TreeNode(9)));
            InOrder(InvertTree(root1));
            Console.WriteLine();

            TreeNode root2 = new TreeNode(2, new TreeNode(1), new TreeNode(3));
            InOrder(InvertTree(root2));
            Console.WriteLine();

            TreeNode root3 = null;
            InOrder(InvertTree(root3));
            Console.WriteLine();
        }

        public static TreeNode InvertTree(TreeNode root)
        {
            InvertRec(root);

            return root;
        }

        private static void InvertRec(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            TreeNode temp = root.left;
            root.left = root.right;
            root.right = temp;

            InvertRec(root.right);
            InvertRec(root.left);
        }

        private static void InOrder(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            InOrder(root.left);
            Console.WriteLine(root.val);
            InOrder(root.right);
        }
    }
}
