using System;
using System.Collections.Generic;

namespace _653._Two_Sum_IV___Input_is_a_BST
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root1 = new TreeNode(5, new TreeNode(3, new TreeNode(2), new TreeNode(4)), new TreeNode(6, null, new TreeNode(7)));
            int k1 = 9;
            Console.WriteLine(FindTarget(root1, k1));

            TreeNode root2 = new TreeNode(5, new TreeNode(3, new TreeNode(2), new TreeNode(4)), new TreeNode(6, null, new TreeNode(7)));
            int k2 = 28;
            Console.WriteLine(FindTarget(root2, k2));

            TreeNode root3 = new TreeNode(2, new TreeNode(1, new TreeNode(3)));
            int k3 = 4;
            Console.WriteLine(FindTarget(root3, k3));

            TreeNode root4 = new TreeNode(2, new TreeNode(1, new TreeNode(3)));
            int k4 = 1;
            Console.WriteLine(FindTarget(root4, k4));

            TreeNode root5 = new TreeNode(2, new TreeNode(1, new TreeNode(3)));
            int k5 = 3;
            Console.WriteLine(FindTarget(root5, k5));
        }

        public static bool FindTarget(TreeNode root, int k)
        {
            HashSet<int> visitedValues = new HashSet<int>();
            Queue<TreeNode> nodes = new Queue<TreeNode>();
            nodes.Enqueue(root);

            while (nodes.Count > 0)
            {
                TreeNode currentNode = nodes.Dequeue();
                int difference = k - currentNode.val;

                if (visitedValues.Contains(difference))
                {
                    return true;
                }

                visitedValues.Add(currentNode.val);

                if (currentNode.left != null)
                {
                    nodes.Enqueue(currentNode.left);
                }

                if (currentNode.right != null)
                {
                    nodes.Enqueue(currentNode.right);
                }
            }

            return false;
        }
    }
}
