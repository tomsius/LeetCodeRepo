using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _938.Range_Sum_of_BST
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode node1 = new TreeNode(10);
            TreeNode node2 = new TreeNode(5);
            TreeNode node3 = new TreeNode(15);
            TreeNode node4 = new TreeNode(3);
            TreeNode node5 = new TreeNode(7);
            TreeNode node6 = new TreeNode(18);

            node1.left = node2;
            node1.right = node3;
            node2.left = node4;
            node2.right = node5;
            node3.right = node6;

            int low1 = 7;
            int high1 = 15;

            Console.WriteLine(RangeSumBST(node1, low1, high1));

            TreeNode node11 = new TreeNode(10);
            TreeNode node12 = new TreeNode(5);
            TreeNode node13 = new TreeNode(3);
            TreeNode node14 = new TreeNode(1);
            TreeNode node15 = new TreeNode(7);
            TreeNode node16 = new TreeNode(6);
            TreeNode node17 = new TreeNode(15);
            TreeNode node18 = new TreeNode(13);
            TreeNode node19 = new TreeNode(18);

            node11.left = node12;
            node11.right = node17;
            node12.left = node13;
            node12.right = node15;
            node13.left = node14;
            node15.left = node16;
            node17.left = node18;
            node17.right = node19;

            int low2 = 6;
            int high2 = 10;

            Console.WriteLine(RangeSumBST(node11, low2, high2));

            Console.ReadKey();
        }

        public static int RangeSumBST(TreeNode root, int low, int high)
        {
            int sum = 0;
            FindSum(root, low, high, ref sum);
            return sum;
        }

        private static void FindSum(TreeNode root, int low, int high, ref int sum)
        {
            if (root == null)
            {
                return;
            }

            if (root.val >= low && root.val <= high)
            {
                sum += root.val;
                
            }

            FindSum(root.left, low, high, ref sum);
            FindSum(root.right, low, high, ref sum);
        }
    }
}
