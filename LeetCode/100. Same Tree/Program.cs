using System;
using System.Collections.Generic;

namespace _100._Same_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode p1 = new TreeNode(1, new TreeNode(2), new TreeNode(3));
            TreeNode q1 = new TreeNode(1, new TreeNode(2), new TreeNode(3));
            Console.WriteLine(IsSameTree1(p1, q1));
            Console.WriteLine(IsSameTree2(p1, q1));
            Console.WriteLine(IsSameTree3(p1, q1));

            TreeNode p2 = new TreeNode(1, new TreeNode(2));
            TreeNode q2 = new TreeNode(1, null, new TreeNode(3));
            Console.WriteLine(IsSameTree1(p2, q2));
            Console.WriteLine(IsSameTree2(p2, q2));
            Console.WriteLine(IsSameTree3(p2, q2));

            TreeNode p3 = new TreeNode(1, new TreeNode(2), new TreeNode(1));
            TreeNode q3 = new TreeNode(1, new TreeNode(1), new TreeNode(2));
            Console.WriteLine(IsSameTree1(p3, q3));
            Console.WriteLine(IsSameTree2(p3, q3));
            Console.WriteLine(IsSameTree3(p3, q3));
        }

        public static bool IsSameTree1(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
            {
                return true;
            }

            if (p == null && q != null || p != null && q == null)
            {
                return false;
            }

            if (p.val != q.val)
            {
                return false;
            }

            if (p.left == null && q.left != null || p.left != null && q.left == null)
            {
                return false;
            }

            if (p.right == null && q.right != null || p.right != null && q.right == null)
            {
                return false;
            }

            if (p.left == null && p.right == null && q.left == null && q.left == null)
            {
                return true;
            }

            return IsSameTree1(p.left, q.left) && IsSameTree1(p.right, q.right);
        }

        public static bool IsSameTree2(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
            {
                return true;
            }

            if (p == null && q != null || p != null && q == null)
            {
                return false;
            }

            if (p.val != q.val)
            {
                return false;
            }

            return IsSameTree1(p.left, q.left) && IsSameTree1(p.right, q.right);
        }

        public static bool IsSameTree3(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
            {
                return true;
            }
            else if (p == null || q == null)
            {
                return false;
            }

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(p);
            queue.Enqueue(q);

            while (queue.Count > 0)
            {
                TreeNode firstNode = queue.Dequeue();
                TreeNode secondNode = queue.Dequeue();

                if (firstNode == null && secondNode == null)
                {
                    continue;
                }
                else if (firstNode == null || secondNode == null)
                {
                    return false;
                }

                if (firstNode.val != secondNode.val)
                {
                    return false;
                }

                queue.Enqueue(firstNode.left);
                queue.Enqueue(secondNode.left);
                queue.Enqueue(firstNode.right);
                queue.Enqueue(secondNode.right);
            }

            return true;
        }
    }
}
