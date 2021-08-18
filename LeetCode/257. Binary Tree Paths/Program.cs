using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _257._Binary_Tree_Paths
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root1 = new TreeNode(1, new TreeNode(2, null, new TreeNode(5)), new TreeNode(3));
            Console.WriteLine(String.Join(", ", BinaryTreePaths(root1)));

            TreeNode root2 = new TreeNode(1);
            Console.WriteLine(String.Join(", ", BinaryTreePaths(root2)));

            TreeNode root3 = new TreeNode(1, new TreeNode(2, new TreeNode(5), new TreeNode(6)), new TreeNode(3));
            Console.WriteLine(String.Join(", ", BinaryTreePaths(root3)));
        }

        public static IList<string> BinaryTreePaths(TreeNode root)
        {
            IList<string> paths = new List<string>();
            StringBuilder sb = new StringBuilder();

            BuildPath(root, sb, paths);

            return paths;
        }

        private static void BuildPath(TreeNode node, StringBuilder sb, IList<string> paths)
        {
            if (node == null) 
            {
                return;
            }

            int len = sb.Length;
            sb.Append(node.val);

            if (node.left == null && node.right == null)
            {
                paths.Add(sb.ToString());
            }
            else
            {
                sb.Append("->");
                BuildPath(node.left, sb, paths);
                BuildPath(node.right, sb, paths);
            }

            sb.Length = len;
        }
    }
}
