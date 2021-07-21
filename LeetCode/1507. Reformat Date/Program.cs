using System;
using System.Collections.Generic;
using System.Text;

namespace _1507._Reformat_Date
{
    class Program
    {
        static void Main(string[] args)
        {
            string date1 = "20th Oct 2052";
            Console.WriteLine(ReformatDate(date1));

            string date2 = "6th Jun 1933";
            Console.WriteLine(ReformatDate(date2));

            string date3 = "26th May 1960";
            Console.WriteLine(ReformatDate(date3));
        }

        public static string ReformatDate(string date)
        {
            string[] dateParts = date.Split(' ');
            string day = dateParts[0].Substring(0, dateParts[0].Length - 2);
            string month = dateParts[1];
            string year = dateParts[2];

            Dictionary<string, string> months = new Dictionary<string, string>()
            {
                ["Jan"] = "01",
                ["Feb"] = "02",
                ["Mar"] = "03",
                ["Apr"] = "04",
                ["May"] = "05",
                ["Jun"] = "06",
                ["Jul"] = "07",
                ["Aug"] = "08",
                ["Sep"] = "09",
                ["Oct"] = "10",
                ["Nov"] = "11",
                ["Dec"] = "12"
            };

            StringBuilder sb = new StringBuilder(year);
            sb.Append('-');

            sb.Append(months[month]);
            sb.Append('-');

            if (day.Length == 1)
            {
                sb.Append('0');
                sb.Append(day);
            }
            else
            {
                sb.Append(day);
            }

            return sb.ToString();
        }
    }
}
