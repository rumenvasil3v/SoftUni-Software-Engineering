namespace _01._Company_Roster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();

            decimal highestAverageSalary = 0;

            for (int e = 0; e < numberOfLines; e++)
            {
                string[] arguments = Console
                    .ReadLine()
                    .Split(' ');

                string employeeName = arguments[0];
                decimal employeeSalary = decimal.Parse(arguments[1]);
                string employeeDepartment = arguments[2];

                Employee employee = new Employee(employeeName, employeeSalary, employeeDepartment);

                var sameDep = employees.FirstOrDefault(x => x.Department == employee.Department);  

                employees.Add(employee);
            }

            foreach (var employee in employees.Where(x => x.Salary))
            {

            }
        }
    }

    public class Employee
    {

        public Employee(string name, decimal salary, string department)
        {
            Name = name;
            Salary = salary;
            Department = department;
        }

        public string Name { get; set; }

        public decimal Salary { get; set; }

        public string Department { get; set; }

        public override string ToString()
        {


            return string.Empty;
        }
    }
}