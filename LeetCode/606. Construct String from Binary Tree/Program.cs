using System;
using System.Text;

namespace _606._Construct_String_from_Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root1 = new TreeNode(1, new TreeNode(2, new TreeNode(4)), new TreeNode(3));
            Console.WriteLine(Tree2str(root1));

            TreeNode root2 = new TreeNode(1, new TreeNode(2, null, new TreeNode(4)), new TreeNode(3));
            Console.WriteLine(Tree2str(root2));
        }

        public static string Tree2str(TreeNode root)
        {
            StringBuilder sb = new StringBuilder();

            PreOrder(root, sb);

            return sb.ToString();
        }

        private static void PreOrder(TreeNode node, StringBuilder sb)
        {
            if (node == null)
            {
                return;
            }

            sb.Append(node.val);

            if (node.left == null && node.right == null)
            {
                return;
            }

            sb.Append('(');
            PreOrder(node.left, sb);
            sb.Append(')');

            if (node.right == null)
            {
                return;
            }

            sb.Append('(');
            PreOrder(node.right, sb);
            sb.Append(')');
        }
    }
}
