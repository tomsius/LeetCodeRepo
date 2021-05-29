using System;

namespace _1450._Number_of_Students_Doing_Homework_at_a_Given_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] startTime1 = { 1, 2, 3 };
            int[] endTime1 = { 3, 2, 7 };
            int queryTime1 = 4;
            Console.WriteLine(BusyStudent(startTime1, endTime1, queryTime1));

            int[] startTime2 = { 4 };
            int[] endTime2 = { 4 };
            int queryTime2 = 4;
            Console.WriteLine(BusyStudent(startTime2, endTime2, queryTime2));

            int[] startTime3 = { 4 };
            int[] endTime3 = { 4 };
            int queryTime3 = 5;
            Console.WriteLine(BusyStudent(startTime3, endTime3, queryTime3));

            int[] startTime4 = { 1,1,1,1 };
            int[] endTime4 = { 1,3,2,4 };
            int queryTime4 = 7;
            Console.WriteLine(BusyStudent(startTime4, endTime4, queryTime4));

            int[] startTime5 = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] endTime5 = { 10, 10, 10, 10, 10, 10, 10, 10, 10 };
            int queryTime5 = 5;
            Console.WriteLine(BusyStudent(startTime5, endTime5, queryTime5));
        }

        public static int BusyStudent(int[] startTime, int[] endTime, int queryTime)
        {
            int studentsCount = 0;

            for (int i = 0; i < startTime.Length; i++)
            {
                if (startTime[i] <= queryTime && endTime[i] >= queryTime)
                {
                    studentsCount++;
                }
            }

            return studentsCount;
        }
    }
}
