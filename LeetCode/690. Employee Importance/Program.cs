using System;
using System.Collections.Generic;
using System.Linq;

namespace _690._Employee_Importance
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Employee> employees1 = new List<Employee>
            {
                new Employee { id = 1, importance = 5, subordinates = new List<int> { 2, 3 } },
                new Employee { id = 2, importance = 3, subordinates = new List<int>() },
                new Employee { id = 3, importance = 3, subordinates = new List<int>() }
            };
            int id1 = 1;
            Console.WriteLine(GetImportance1(employees1, id1));
            Console.WriteLine(GetImportance2(employees1, id1));

            IList<Employee> employees2 = new List<Employee>
            {
                new Employee { id = 1, importance = 2, subordinates = new List<int> { 5 } },
                new Employee { id = 5, importance = -3, subordinates = new List<int>() }
            };
            int id2 = 5;
            Console.WriteLine(GetImportance1(employees2, id2));
            Console.WriteLine(GetImportance2(employees2, id2));

            IList<Employee> employees3 = new List<Employee>
            {
                new Employee { id = 1, importance = 5, subordinates = new List<int> { 2, 3 } },
                new Employee { id = 2, importance = 3, subordinates = new List<int> { 4 } },
                new Employee { id = 3, importance = 4, subordinates = new List<int>() },
                new Employee { id = 4, importance = 1, subordinates = new List<int>() }
            };
            int id3 = 1;
            Console.WriteLine(GetImportance1(employees3, id3));
            Console.WriteLine(GetImportance2(employees3, id3));
        }

        public static int GetImportance1(IList<Employee> employees, int id)
        {
            int importanceSum = 0;
            employees = employees.OrderBy(x => x.id).ToList();

            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].id == id)
                {
                    importanceSum += employees[i].importance;
                    Queue<int> subordinatesIds = new Queue<int>(employees[i].subordinates);

                    importanceSum += GetSubordinatesImportances(employees, subordinatesIds);

                    break;
                }
            }

            return importanceSum;
        }

        private static int GetSubordinatesImportances(IList<Employee> employees, Queue<int> subordinatesIds)
        {
            int importanceSum = 0;

            for (int i = 0; i < employees.Count; i++)
            {
                if (subordinatesIds.Count == 0)
                {
                    break;
                }

                if (employees[i].id == subordinatesIds.Peek())
                {
                    importanceSum += employees[i].importance;

                    if (employees[i].subordinates.Count > 0)
                    {
                        Queue<int> subordinates = new Queue<int>(employees[i].subordinates);
                        importanceSum += GetSubordinatesImportances(employees, subordinates);
                    }

                    subordinatesIds.Dequeue();
                }
            }

            return importanceSum;
        }

        public static int GetImportance2(IList<Employee> employees, int id)
        {
            Dictionary<int, Employee> employeesById = new Dictionary<int, Employee>();

            foreach (var employee in employees)
            {
                employeesById.Add(employee.id, employee);
            }

            int importanceSum = GetImportanceSumDFS(employeesById, id);

            return importanceSum;
        }

        private static int GetImportanceSumDFS(Dictionary<int, Employee> employeesById, int id)
        {
            Employee employee = employeesById[id];
            int sum = employee.importance;

            foreach (var subordinateId in employee.subordinates)
            {
                sum += GetImportanceSumDFS(employeesById, subordinateId);
            }

            return sum;
        }
    }
}
