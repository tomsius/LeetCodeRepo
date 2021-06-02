using System;
using System.Collections.Generic;

namespace _589._N_ary_Tree_Preorder_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root1 = new Node(1, new List<Node> 
            {
                new Node(3, new List<Node>
                    {
                        new Node(5, new List<Node>()),
                        new Node(6, new List<Node>())
                    }),
                new Node(2, new List<Node>()),
                new Node(4, new List<Node>()),
            });
            Console.WriteLine(string.Join(" ", Preorder(root1)));

            Node root2 = new Node(1, new List<Node> 
            {
                new Node(2, new List<Node>()),
                new Node(3, new List<Node> 
                    {
                        new Node(6, new List<Node>()),
                        new Node(7, new List<Node>
                            {
                                new Node(11, new List<Node>
                                    {
                                        new Node(14, new List<Node>())
                                    })
                            })
                    }),
                new Node(4, new List<Node>
                    {
                        new Node(8, new List<Node>
                            {
                                new Node(12, new List<Node>())
                            })
                    }),
                new Node(5, new List<Node>
                    {
                        new Node(9, new List<Node>
                            {
                                new Node(13, new List<Node>())
                            }),
                        new Node(10, new List<Node>())
                    })
            });
            Console.WriteLine(string.Join(" ", Preorder(root2)));
        }

        public static IList<int> Preorder(Node root)
        {
            List<int> result = new List<int>();

            PreorderRec(root, result);

            return result;
        }

        private static void PreorderRec(Node node, List<int> result)
        {
            if (node == null)
            {
                return;
            }

            result.Add(node.val);

            foreach (var child in node.children)
            {
                PreorderRec(child, result);
            }
        }
    }
}
