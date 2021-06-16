using System;

namespace _821._Shortest_Distance_to_a_Character
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "loveleetcode";
            char c1 = 'e';
            Console.WriteLine(String.Join(", ", ShortestToChar(s1, c1)));

            string s2 = "aaab";
            char c2 = 'b';
            Console.WriteLine(String.Join(", ", ShortestToChar(s2, c2)));
        }

        public static int[] ShortestToChar(string s, char c)
        {
            int[] distances = new int[s.Length];

            for (int i = 0; i < distances.Length; i++)
            {
                int indexToLeft = s.LastIndexOf(c, i) == -1 ? int.MaxValue : s.LastIndexOf(c, i);
                int indexToRight = s.IndexOf(c, i) == -1 ? int.MaxValue : s.IndexOf(c, i);
                int distance = Math.Min(Math.Abs(indexToLeft - i), Math.Abs(indexToRight - i));

                distances[i] = distance;
            }

            return distances;
        }
    }
}
