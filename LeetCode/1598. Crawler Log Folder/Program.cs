using System;
using System.Collections.Generic;

namespace _1598._Crawler_Log_Folder
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] logs1 = { "d1/", "d2/", "../", "d21/", "./" };
            Console.WriteLine(MinOperations1(logs1));
            Console.WriteLine(MinOperations2(logs1));

            string[] logs2 = { "d1/", "d2/", "./", "d3/", "../", "d31/" };
            Console.WriteLine(MinOperations1(logs2));
            Console.WriteLine(MinOperations2(logs2));

            string[] logs3 = { "d1/", "../", "../", "../" };
            Console.WriteLine(MinOperations1(logs3));
            Console.WriteLine(MinOperations2(logs3));
        }

        public static int MinOperations1(string[] logs)
        {
            Stack<string> folders = new Stack<string>();

            foreach (var log in logs)
            {
                switch (log)
                {
                    case "./":
                        break;
                    case "../":
                        if (folders.Count > 0)
                        {
                            folders.Pop();
                        }
                        break;
                    default:
                        folders.Push(log);
                        break;
                }
            }

            return folders.Count;
        }

        public static int MinOperations2(string[] logs)
        {
            int depth = 0;

            foreach (var log in logs)
            {
                switch (log)
                {
                    case "./":
                        break;
                    case "../":
                        if (depth > 0)
                        {
                            depth--;
                        }
                        break;
                    default:
                        depth++;
                        break;
                }
            }

            return depth;
        }
    }
}
