namespace _07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Company> companies = new Dictionary<string, Company>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] arguments = input
                    .Split(" -> ");

                string companyName = arguments[0];
                string employeeId = arguments[1];

                Company company = new Company(companyName);

                if (!companies.ContainsKey(company.Name))
                {
                    company.EmployeeId.Add(employeeId);
                    companies[company.Name] = company;
                    continue;
                }

                bool sameId = companies[company.Name].EmployeeId.Contains(employeeId);
                if (sameId)
                {
                    continue;
                }

                companies[company.Name].EmployeeId.Add(employeeId);
            }

            foreach (Company company in companies.Values)
            {
                Console.WriteLine(company.ToString().Trim());
            }
        }
    }

    public class Company
    {

        public Company(string name)
        {
            this.Name = name;
            this.EmployeeId = new List<string>();
        }

        public string Name { get; set; }

        public List<string> EmployeeId { get; set; }

        public override string ToString()
        {
            string result = string.Empty;

            result += $"{this.Name}\n";

            foreach (string employee in this.EmployeeId)
            {
                result += $"-- {employee}\n";
            }

            return result;
        }
    }
}