using System;
using System.Collections.Generic;

namespace _590._N_ary_Tree_Postorder_Traversal
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
            Console.WriteLine(string.Join(" ", Postorder(root1)));

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
            Console.WriteLine(string.Join(" ", Postorder(root2)));
        }

        public static IList<int> Postorder(Node root)
        {
            List<int> result = new List<int>();

            PostorderRec(root, result);

            return result;
        }

        private static void PostorderRec(Node node, List<int> result)
        {
            if (node == null)
            {
                return;
            }

            foreach (var child in node.children)
            {
                PostorderRec(child, result);
            }

            result.Add(node.val);
        }
    }
}
