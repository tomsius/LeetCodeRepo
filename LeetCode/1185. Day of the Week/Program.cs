using System;

namespace _1185._Day_of_the_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int day1 = 31;
            int month1 = 8;
            int year1 = 2019;
            Console.WriteLine(DayOfTheWeek(day1, month1, year1));

            int day2 = 18;
            int month2 = 7;
            int year2 = 1999;
            Console.WriteLine(DayOfTheWeek(day2, month2, year2));

            int day3 = 15;
            int month3 = 8;
            int year3 = 1993;
            Console.WriteLine(DayOfTheWeek(day3, month3, year3));
        }

        public static string DayOfTheWeek(int day, int month, int year)
        {
            DateTime dt = new DateTime(year, month, day);

            return dt.DayOfWeek.ToString();
        }
    }
}
