using String = System.String;

namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> products = new Dictionary<string, Product>();

            string input;
            while ((input = Console.ReadLine()) != "buy")
            {
                string[] arguments = input
                    .Split(' ');

                string productName = arguments[0];
                decimal productPrice = decimal.Parse(arguments[1]);
                int productQuantity = int.Parse(arguments[2]);

                Product product = new Product(productName, productPrice, productQuantity);

                if (!products.ContainsKey(product.Name))
                {
                    products.Add(product.Name, product);
                }
                else
                {
                    products[product.Name].Price = productPrice;
                    products[product.Name].Quantity += productQuantity;
                }
            }

            foreach (Product product in products.Values)
            {
                Console.WriteLine($"{product.Name} -> {product.TotalPrice}");
            }
        }
    }

    public class Product
    {

        public Product(string name, decimal price, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public decimal TotalPrice
        {
            get
            {
                return this.Price * this.Quantity;
            }
        }

        public override string ToString()
        {
            return String.Format("{0} -> {1}", this.Name, this.TotalPrice);
        }
    }
}