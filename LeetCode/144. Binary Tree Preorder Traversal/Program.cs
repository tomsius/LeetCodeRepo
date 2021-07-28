using System;
using System.Collections.Generic;
using System.Linq;

namespace _144._Binary_Tree_Preorder_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root1 = new TreeNode(1, null, new TreeNode(2, new TreeNode(3)));
            Console.WriteLine(String.Join(", ", PreorderTraversal1(root1)));
            Console.WriteLine(String.Join(", ", PreorderTraversal2(root1)));

            TreeNode root2 = new TreeNode();
            Console.WriteLine(String.Join(", ", PreorderTraversal1(root2)));
            Console.WriteLine(String.Join(", ", PreorderTraversal2(root2)));

            TreeNode root3 = new TreeNode(1);
            Console.WriteLine(String.Join(", ", PreorderTraversal1(root3)));
            Console.WriteLine(String.Join(", ", PreorderTraversal2(root3)));

            TreeNode root4 = new TreeNode(1, new TreeNode(2));
            Console.WriteLine(String.Join(", ", PreorderTraversal1(root4)));
            Console.WriteLine(String.Join(", ", PreorderTraversal2(root4)));

            TreeNode root5 = new TreeNode(1, null, new TreeNode(2));
            Console.WriteLine(String.Join(", ", PreorderTraversal1(root5)));
            Console.WriteLine(String.Join(", ", PreorderTraversal1(root5)));
        }

        public static IList<int> PreorderTraversal1(TreeNode root)
        {
            IList<int> values = new List<int>();
            PreorderRec(root, values);

            return values;
        }

        private static void PreorderRec(TreeNode node, IList<int> values)
        {
            if (node == null)
            {
                return;
            }

            values.Add(node.val);
            PreorderRec(node.left, values);
            PreorderRec(node.right, values);
        }

        public static IList<int> PreorderTraversal2(TreeNode root)
        {
            IList<int> values = new List<int>();

            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                TreeNode current = stack.Pop();

                if (current != null)
                {
                    values.Add(current.val);
                    stack.Push(current.right);
                    stack.Push(current.left);
                }
            }

            return values;
        }
    }
}
