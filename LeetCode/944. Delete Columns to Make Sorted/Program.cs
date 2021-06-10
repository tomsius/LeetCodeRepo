using System;

namespace _944._Delete_Columns_to_Make_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs1 = { "cba", "daf", "ghi" };
            Console.WriteLine(MinDeletionSize(strs1));

            string[] strs2 = { "a", "b" };
            Console.WriteLine(MinDeletionSize(strs2));

            string[] strs3 = { "zyx", "wvu", "tsr" };
            Console.WriteLine(MinDeletionSize(strs3));
        }

        public static int MinDeletionSize(string[] strs)
        {
            int deletedColumns = 0;

            for (int letter = 0; letter < strs[0].Length; letter++)
            {
                for (int i = 0; i < strs.Length - 1; i++)
                {
                    if (strs[i][letter] > strs[i + 1][letter])
                    {
                        deletedColumns++;
                        break;
                    }
                }
            }

            return deletedColumns;
        }
    }
}
