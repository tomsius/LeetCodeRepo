using System;
using System.Collections.Generic;

namespace _1791._Find_Center_of_Star_Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] edges1 = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 2, 3 },
                new int[] { 4, 2 }
            };
            Console.WriteLine(FindCenter1(edges1));
            Console.WriteLine(FindCenter2(edges1));

            int[][] edges2 = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 5, 1 },
                new int[] { 1, 3 },
                new int[] { 1, 4 }
            };
            Console.WriteLine(FindCenter1(edges2));
            Console.WriteLine(FindCenter2(edges2));
        }

        public static int FindCenter1(int[][] edges)
        {
            int[] stars = new int[edges.Length + 1];
            int centerStar = 0;

            foreach (var edge in edges)
            {
                for (int i = 0; i < edge.Length; i++)
                {
                    stars[edge[i] - 1]++;

                    if (stars[edge[i] - 1] == edge.Length)
                    {
                        centerStar = edge[i];
                        break;
                    }
                }
            }

            return centerStar;
        }

        public static int FindCenter2(int[][] edges)
        {
            int[] firstEdge = edges[0];
            int[] secondEdge = edges[1];

            if (firstEdge[0] == secondEdge[0] || firstEdge[0] == secondEdge[1])
            {
                return firstEdge[0];
            }

            return firstEdge[1];
        }
    }
}
