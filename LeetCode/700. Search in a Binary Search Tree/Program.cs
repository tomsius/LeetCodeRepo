using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _700.Search_in_a_Binary_Search_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode node1 = new TreeNode(4);
            TreeNode node2 = new TreeNode(2);
            TreeNode node3 = new TreeNode(7);
            TreeNode node4 = new TreeNode(1);
            TreeNode node5 = new TreeNode(3);

            node1.left = node2;
            node1.right = node3;
            node2.left = node4;
            node2.right = node5;

            int value1 = 2;
            Console.WriteLine(SearchBST(node1, value1) == null ? "[]" : SearchBST(node1, value1).val.ToString());
            Console.WriteLine(SearchBST2(node1, value1) == null ? "[]" : SearchBST2(node1, value1).val.ToString());

            int value2 = 5;
            Console.WriteLine(SearchBST(node1, value2) == null ? "[]" : SearchBST(node1, value2).val.ToString());
            Console.WriteLine(SearchBST2(node1, value2) == null ? "[]" : SearchBST2(node1, value2).val.ToString());

            Console.ReadKey();
        }
        public static TreeNode SearchBST(TreeNode root, int val)
        {
            while (true)
            {
                if (root.val == val)
                {
                    return root;
                }

                if (root.val > val && root.left != null)
                {
                    root = root.left;
                }
                else if (root.val < val && root.right != null)
                {
                    root = root.right;
                }
                else
                {
                    return null;
                }
            }
        }

        public static TreeNode SearchBST2(TreeNode root, int val)
        {
            while (root != null && root.val != val)
            {
                root = root.val < val ? root.right : root.left;
            }

            return root;
        }
    }
}
