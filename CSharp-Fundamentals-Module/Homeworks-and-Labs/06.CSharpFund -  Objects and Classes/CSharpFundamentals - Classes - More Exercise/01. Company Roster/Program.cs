using System.Data.Common;

namespace _01._Company_Roster
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<Employee>> departments = new Dictionary<string, List<Employee>>();

            int count = 1;
            int numberOfEmployees = int.Parse(Console.ReadLine());

            for (int n = 0; n < numberOfEmployees; n++)
            {
                string[] dataForEmployee = Console.ReadLine().Split();

                string employeeName = dataForEmployee[0];
                decimal employeeSalary = decimal.Parse(dataForEmployee[1]);
                string departmentName = dataForEmployee[2];

                Employee employee = new Employee(employeeName, employeeSalary, departmentName);

                if (!departments.ContainsKey(departmentName))
                {
                    List<Employee> currentEmployee = new List<Employee>();

                    currentEmployee.Add(employee);
                    departments.Add(departmentName, new List<Employee>(currentEmployee));
                    continue;
                }

                departments[departmentName].Add(employee);
            }

            decimal maxAverageSalary = 0;
            List<Employee> highestAverageSalary = new List<Employee>();

            string highestAverageSalaryDepartmentName = string.Empty;

            foreach (var kvp in departments)
            {
                decimal currentAverageSalary = kvp.Value.Average(x => x.Salary);

                if (currentAverageSalary > maxAverageSalary)
                {
                    maxAverageSalary = currentAverageSalary;
                    highestAverageSalary = new List<Employee>();

                    foreach (var val in kvp.Value)
                    {
                        highestAverageSalary.Add(val);
                    }
                    highestAverageSalaryDepartmentName = kvp.Key;
                }
            }

            Console.WriteLine($"Highest Average Salary: {highestAverageSalaryDepartmentName}");

            foreach (var val in highestAverageSalary.OrderByDescending(x => x.Salary))
            {
                Console.WriteLine($"{val.Name} {val.Salary:F2}");
            }
        }
    }

    public class Employee
    {
        public Employee(string employeeName, decimal employeeSalary, string departmentName)
        {
            Name = employeeName;
            Salary = employeeSalary;
            DepartmentName = departmentName;
        }

        public string Name { get; set; }

        public decimal Salary { get; set; }

        public string DepartmentName { get; set; }

    }
}