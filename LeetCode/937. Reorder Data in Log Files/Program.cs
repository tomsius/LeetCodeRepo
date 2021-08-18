using System;
using System.Linq;

namespace _937._Reorder_Data_in_Log_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] logs1 = { "dig1 8 1 5 1", "let1 art can", "dig2 3 6", "let2 own kit dig", "let3 art zero" };
            Console.WriteLine(String.Join(", ", ReorderLogFiles(logs1)));

            string[] logs2 = { "a1 9 2 3 1", "g1 act car", "zo4 4 7", "ab1 off key dog", "a8 act zoo" };
            Console.WriteLine(String.Join(", ", ReorderLogFiles(logs2)));
        }

        public static string[] ReorderLogFiles(string[] logs)
        {
            LogComparer comparer = new LogComparer();

            logs = logs.OrderBy(x => x, comparer).ToArray();

            return logs;
        }
    }
}
