/*
%George%<Croissant>|2|10.3$
%Peter%<Gum>|1|1.3$
%Maria%<Cola>|1|2.4$
end of shift

%InvalidName%<Croissant>|2|10.3$
%Peter%<Gum>1.3$
%Maria%<Cola>|1|2.4
%Valid%<Valid>valid|10|valid20$
end of shift

 */

using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<customer>[A-Z][a-z]+)%([^|$%.]*?)<(?<product>[A-Za-z0-9_]+)>([^|$%.]*?)\|(?<count>\d+)\|([^|$%.]*?)(?<price>\d+|\d+\.\d+)\$";

            Regex regex = new Regex(pattern);
            List<Product> products = new List<Product>();

            string input;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                Match match = regex.Match(input);
                if (!match.Success)
                {
                    continue;
                }

                string customerName = match.Groups["customer"].Value;
                string productName = match.Groups["product"].Value;
                int productCount = int.Parse(match.Groups["count"].Value);
                decimal productPrice = decimal.Parse(match.Groups["price"].Value);

                Product product = new Product(productName, customerName, productCount, productPrice);

                products.Add(product);
            }

            PrintResult(products);
        }

        static void PrintResult(List<Product> products)
        {
            decimal totalIncome = 0;
            foreach (Product product in products)
            {
                Console.WriteLine($"{product.CustomerName}: {product.Name} - {product.TotalPrice:F2}");
                totalIncome += product.TotalPrice;
            }

            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }

    public class Product
    {

        public Product(string name, string customerName, int count, decimal price)
        {
            Name = name;
            CustomerName = customerName;
            Count = count;
            Price = price;
        }

        public string Name { get; set; }

        public string CustomerName { get; set; }

        public int Count { get; set; }

        public decimal Price { get; set; }

        public decimal TotalPrice
        {
            get
            {
                return this.Price * this.Count;
            }
        }
    }
}