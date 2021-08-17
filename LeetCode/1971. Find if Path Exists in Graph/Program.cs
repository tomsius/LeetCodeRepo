using System;
using System.Collections.Generic;

namespace _1971._Find_if_Path_Exists_in_Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 3;
            int[][] edges1 = new int[][]
            {
                new int[] { 0, 1 },
                new int[] { 1, 2 },
                new int[] { 2, 0 }
            };
            int start1 = 0;
            int end1 = 2;
            Console.WriteLine(ValidPath(n1, edges1, start1, end1));

            int n2 = 6;
            int[][] edges2 = new int[][]
            {
                new int[] { 0, 1 },
                new int[] { 0, 2 },
                new int[] { 3, 5 },
                new int[] { 5, 4 },
                new int[] { 4, 3 }
            };
            int start2 = 0;
            int end2 = 5;
            Console.WriteLine(ValidPath(n2, edges2, start2, end2));
        }

        public static bool ValidPath(int n, int[][] edges, int start, int end)
        {
            Dictionary<int, List<int>> destinations = new Dictionary<int, List<int>>();
            bool[] visited = new bool[n];

            foreach (var edge in edges)
            {
                if (destinations.ContainsKey(edge[0]))
                {
                    destinations[edge[0]].Add(edge[1]);
                }
                else
                {
                    destinations.Add(edge[0], new List<int> { edge[1] });
                }

                if (destinations.ContainsKey(edge[1]))
                {
                    destinations[edge[1]].Add(edge[0]);
                }
                else
                {
                    destinations.Add(edge[1], new List<int> { edge[0] });
                }
            }

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                int current = queue.Dequeue();

                if (current == end)
                {
                    return true;
                }
                else if (destinations.ContainsKey(current) && !visited[current])
                {
                    foreach (var destination in destinations[current])
                    {
                        queue.Enqueue(destination);
                    }
                }

                visited[current] = true;
            }

            return false;
        }
    }
}
