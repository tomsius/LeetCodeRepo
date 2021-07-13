using System;
using System.Collections.Generic;
using System.Text;

namespace _872._Leaf_Similar_Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root11 = new TreeNode(3, new TreeNode(5, new TreeNode(6), new TreeNode(2, new TreeNode(7), new TreeNode(4))), new TreeNode(1, new TreeNode(9), new TreeNode(8)));
            TreeNode root21 = new TreeNode(3, new TreeNode(5, new TreeNode(6), new TreeNode(7)), new TreeNode(1, new TreeNode(4), new TreeNode(2, new TreeNode(9), new TreeNode(8))));
            Console.WriteLine(LeafSimilar1(root11, root21));
            Console.WriteLine(LeafSimilar2(root11, root21));

            TreeNode root12 = new TreeNode(1);
            TreeNode root22 = new TreeNode(1);
            Console.WriteLine(LeafSimilar1(root12, root22));
            Console.WriteLine(LeafSimilar2(root12, root22));

            TreeNode root13 = new TreeNode(1);
            TreeNode root23 = new TreeNode(2);
            Console.WriteLine(LeafSimilar1(root13, root23));
            Console.WriteLine(LeafSimilar2(root13, root23));

            TreeNode root14 = new TreeNode(1, new TreeNode(2));
            TreeNode root24 = new TreeNode(2, new TreeNode(2));
            Console.WriteLine(LeafSimilar1(root14, root24));
            Console.WriteLine(LeafSimilar2(root14, root24));

            TreeNode root15 = new TreeNode(1, new TreeNode(2), new TreeNode(3));
            TreeNode root25 = new TreeNode(1, new TreeNode(3), new TreeNode(2));
            Console.WriteLine(LeafSimilar1(root15, root25));
            Console.WriteLine(LeafSimilar2(root15, root25));

            TreeNode root16 = new TreeNode(3, new TreeNode(5, new TreeNode(6), new TreeNode(2, new TreeNode(7), new TreeNode(14))), new TreeNode(1, new TreeNode(9), new TreeNode(8)));
            TreeNode root26 = new TreeNode(3, new TreeNode(5, new TreeNode(6), new TreeNode(71)), new TreeNode(1, new TreeNode(4), new TreeNode(2, new TreeNode(9), new TreeNode(8))));
            Console.WriteLine(LeafSimilar1(root16, root26));
            Console.WriteLine(LeafSimilar2(root16, root26));
        }

        public static bool LeafSimilar1(TreeNode root1, TreeNode root2)
        {
            List<int> root1Leaves = new List<int>();
            List<int> root2Leaves = new List<int>();

            FillLeaves(root1, root1Leaves);
            FillLeaves(root2, root2Leaves);

            if (root1Leaves.Count != root2Leaves.Count)
            {
                return false;
            }

            for (int i = 0; i < root1Leaves.Count; i++)
            {
                if (root1Leaves[i] != root2Leaves[i])
                {
                    return false;
                }
            }

            return true;
        }

        private static void FillLeaves(TreeNode node, List<int> leaves)
        {
            if (node == null)
            {
                return;
            }

            if (node.left == null && node.right == null)
            {
                leaves.Add(node.val);
            }

            FillLeaves(node.left, leaves);
            FillLeaves(node.right, leaves);
        }

        public static bool LeafSimilar2(TreeNode root1, TreeNode root2)
        {
            StringBuilder root1Leaves = new StringBuilder();
            StringBuilder root2Leaves = new StringBuilder();

            FillLeaves(root1, root1Leaves);
            FillLeaves(root2, root2Leaves);

            return root1Leaves.ToString() == root2Leaves.ToString();
        }

        private static void FillLeaves(TreeNode node, StringBuilder leaves)
        {
            if (node == null)
            {
                return;
            }

            if (node.left == null && node.right == null)
            {
                leaves.Append(node.val + " ");
            }

            FillLeaves(node.left, leaves);
            FillLeaves(node.right, leaves);
        }
    }
}
