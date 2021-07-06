using System;
using System.Collections.Generic;

namespace _637._Average_of_Levels_in_Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root1 = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));
            Console.WriteLine(String.Join(", ", AverageOfLevelsDFS(root1)));
            Console.WriteLine(String.Join(", ", AverageOfLevelsBFS(root1)));

            TreeNode root2 = new TreeNode(3, new TreeNode(9, new TreeNode(15), new TreeNode(7)), new TreeNode(20));
            Console.WriteLine(String.Join(", ", AverageOfLevelsDFS(root2)));
            Console.WriteLine(String.Join(", ", AverageOfLevelsBFS(root2)));
        }

        public static IList<double> AverageOfLevelsDFS(TreeNode root)
        {
            List<double> averages = new List<double>();
            List<int> counts = new List<int>();

            DFS(root, 0, averages, counts);

            for (int i = 0; i < averages.Count; i++)
            {
                averages[i] /= counts[i];
            }

            return averages;
        }

        private static void DFS(TreeNode node, int i, List<double> sums, List<int> counts)
        {
            if (node == null)
            {
                return;
            }

            if (i == sums.Count)
            {
                sums.Add(node.val);
                counts.Add(1);
            }
            else
            {
                sums[i] += node.val;
                counts[i]++;
            }

            DFS(node.left, i + 1, sums, counts);
            DFS(node.right, i + 1, sums, counts);
        }

        public static IList<double> AverageOfLevelsBFS(TreeNode root)
        {
            List<double> averages = new List<double>();

            if (root == null)
            {
                return averages;
            }

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            double sum = 0;
            while (queue.Count != 0)
            {
                int size = queue.Count;

                for (int i = 0; i < size; i++)
                {
                    TreeNode node = queue.Dequeue();
                    sum += node.val;

                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }

                averages.Add(sum / size);
                sum = 0;
            }

            return averages;
        }
    }
}
