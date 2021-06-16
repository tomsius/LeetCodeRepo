using System;
using System.Collections.Generic;
using System.Linq;

namespace _559._Maximum_Depth_of_N_ary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root1 = new Node(1, new List<Node> { new Node(3, new List<Node> { new Node(5), new Node(6) }), new Node(2), new Node(4) });
            Console.WriteLine(MaxDepth(root1));

            Node root2 = new Node(1, new List<Node> { new Node(2), new Node(3, new List<Node> { new Node(6), new Node(7, new List<Node> { new Node(11, new List<Node> { new Node(14) }) }) }), new Node(4, new List<Node> { new Node(8, new List<Node> { new Node(12) }) }), new Node(5, new List<Node> { new Node(9, new List<Node> { new Node(13) }), new Node(10) }) });
            Console.WriteLine(MaxDepth(root2));

            Node root3 = null;
            Console.WriteLine(MaxDepth(root3));
        }

        public static int MaxDepth(Node root)
        {
            if (root == null)
            {
                return 0;
            }

            List<int> depths = new List<int>();
            if (root.children != null)
            {
                foreach (var node in root.children)
                {
                    depths.Add(MaxDepth(node));
                }
            }

            return depths.Count == 0 ? 1 : depths.Max() + 1;
        }
    }
}
