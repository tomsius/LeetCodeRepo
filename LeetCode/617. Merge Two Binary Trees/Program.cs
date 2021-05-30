using System;

namespace _617._Merge_Two_Binary_Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root1 = new TreeNode(1);
            TreeNode node12 = new TreeNode(3);
            TreeNode node13 = new TreeNode(2);
            TreeNode node14 = new TreeNode(5);

            TreeNode root2 = new TreeNode(2);
            TreeNode node22 = new TreeNode(1);
            TreeNode node23 = new TreeNode(3);
            TreeNode node24 = new TreeNode(4);
            TreeNode node25 = new TreeNode(7);

            root1.left = node12;
            root1.right = node13;
            node12.left = node14;

            root2.left = node22;
            root2.right = node23;
            node22.right = node24;
            node23.right = node25;

            InOrderTraverseTree(MergeTrees(root1, root2));
            Console.WriteLine("----------------");

            TreeNode root3 = new TreeNode(1);

            TreeNode root4 = new TreeNode(1);
            TreeNode node42 = new TreeNode(2);
            root4.left = node42;

            InOrderTraverseTree(MergeTrees(root3, root4));
        }

        public static TreeNode MergeTrees(TreeNode root1, TreeNode root2)
        {
            if (root1 == null)
            {
                return root2;
            }

            if (root2 == null)
            {
                return root1;
            }

            root1.val += root2.val;
            root1.left = MergeTrees(root1.left, root2.left);
            root1.right = MergeTrees(root1.right, root2.right);

            return root1;
        }

        public static void InOrderTraverseTree(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            InOrderTraverseTree(root.left);
            Console.WriteLine(root.val);
            InOrderTraverseTree(root.right);
        }
    }
}
