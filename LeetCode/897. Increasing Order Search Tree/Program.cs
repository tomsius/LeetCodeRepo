using System;
using System.Collections.Generic;

namespace _897.Increasing_Order_Search_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode node1 = new TreeNode(1);
            TreeNode node2 = new TreeNode(2);
            TreeNode node3 = new TreeNode(3);
            TreeNode node4 = new TreeNode(4);
            TreeNode node5 = new TreeNode(5);
            TreeNode node6 = new TreeNode(6);
            TreeNode node7 = new TreeNode(7);
            TreeNode node8 = new TreeNode(8);
            TreeNode node9 = new TreeNode(9);

            node5.left = node3;
            node5.right = node6;
            node3.left = node2;
            node3.right = node4;
            node2.left = node1;
            node6.right = node8;
            node8.left = node7;
            node8.right = node9;

            TreeNode temp = IncreasingBST(node5);
            PrintBST(temp);
            Console.WriteLine();

            TreeNode node11 = new TreeNode(5);
            TreeNode node12 = new TreeNode(1);
            TreeNode node13 = new TreeNode(7);

            node11.left = node12;
            node11.right = node13;

            TreeNode temp2 = IncreasingBST(node11);
            PrintBST(temp2);

            Console.ReadKey();
        }

        public static TreeNode IncreasingBST(TreeNode root)
        {
            Queue<int> queue = new Queue<int>();
            FormStack(root, queue);

            TreeNode output = new TreeNode(queue.Dequeue());
            TreeNode toReturn = output;

            while (queue.Count > 0)
            {
                output.right = new TreeNode(queue.Dequeue());
                output = output.right;
            }

            return toReturn;
        }

        private static void FormStack(TreeNode root, Queue<int> queue)
        {
            if (root.left != null)
            {
                FormStack(root.left, queue);
            }

            queue.Enqueue(root.val);

            if (root.right != null)
            {
                FormStack(root.right, queue);
            }
        }

        public static void PrintBST(TreeNode root)
        {
            Console.Write(root.val + " ");

            if (root.right != null)
            {
                PrintBST(root.right);
            }
        }
    }
}
