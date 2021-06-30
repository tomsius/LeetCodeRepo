using System;
using System.Collections.Generic;
using System.Linq;

namespace _1491._Average_Salary_Excluding_the_Minimum_and_Maximum_Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] salary1 = { 4000, 3000, 1000, 2000 };
            Console.WriteLine(Average1(salary1));
            Console.WriteLine(Average2(salary1));

            int[] salary2 = { 1000, 2000, 3000 };
            Console.WriteLine(Average1(salary2));
            Console.WriteLine(Average2(salary2));

            int[] salary3 = { 6000, 5000, 4000, 3000, 2000, 1000 };
            Console.WriteLine(Average1(salary3));
            Console.WriteLine(Average2(salary3));

            int[] salary4 = { 8000, 9000, 2000, 3000, 6000, 1000 };
            Console.WriteLine(Average1(salary4));
            Console.WriteLine(Average2(salary4));
        }

        public static double Average1(int[] salary)
        {
            List<int> salaries = new List<int>(salary);

            salaries.Remove(salaries.Max());
            salaries.Remove(salaries.Min());

            return salaries.Average();
        }

        public static double Average2(int[] salary)
        {
            double salariesSum = 0;
            int maxSalary = salary[0];
            int minSalary = salary[0];

            foreach (var employeeSalary in salary)
            {
                salariesSum += employeeSalary;

                if (maxSalary < employeeSalary)
                {
                    maxSalary = employeeSalary;
                }

                if (minSalary > employeeSalary)
                {
                    minSalary = employeeSalary;
                }
            }

            return (salariesSum - maxSalary - minSalary) / (salary.Length - 2);
        }
    }
}
