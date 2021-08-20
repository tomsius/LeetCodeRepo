using System;

namespace _563._Binary_Tree_Tilt
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root1 = new TreeNode(1, new TreeNode(2), new TreeNode(3));
            Console.WriteLine(FindTilt(root1));

            TreeNode root2 = new TreeNode(4, new TreeNode(2, new TreeNode(3), new TreeNode(5)), new TreeNode(9, null, new TreeNode(7)));
            Console.WriteLine(FindTilt(root2));

            TreeNode root3 = new TreeNode(21, new TreeNode(7, new TreeNode(1, new TreeNode(3), new TreeNode(3)), new TreeNode(1)), new TreeNode(14, new TreeNode(2), new TreeNode(2)));
            Console.WriteLine(FindTilt(root3));
        }

        public static int FindTilt(TreeNode root)
        {
            int tiltValue = 0;

            PostOrder(root, ref tiltValue);

            return tiltValue;
        }

        private static int PostOrder(TreeNode node, ref int tiltValue)
        {
            if (node == null)
            {
                return 0;
            }

            int leftSubtreeSum = PostOrder(node.left, ref tiltValue);
            int rightSubtreeSum = PostOrder(node.right, ref tiltValue);
            tiltValue += Math.Abs(leftSubtreeSum - rightSubtreeSum);

            return node.val + leftSubtreeSum + rightSubtreeSum;
        }
    }
}
