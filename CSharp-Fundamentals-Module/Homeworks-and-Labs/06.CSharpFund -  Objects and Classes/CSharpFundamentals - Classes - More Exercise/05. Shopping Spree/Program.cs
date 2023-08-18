namespace _05._Shopping_Spree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string[] initialPeople = Console.ReadLine().Split(';');

            AddingPeople(people, initialPeople);
            
            List<Product> products = new List<Product>();
            string[] initialProducts = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

            AddingProducts(products, initialProducts);

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] currentPersonData = command.Split();

                string currentPerson = currentPersonData[0];
                string currentProduct = currentPersonData[1];
                decimal currentProductCost = 0;

                for (int n = 0; n < products.Count; n++)
                {
                    if (products[n].Name == currentProduct)
                    {
                        currentProductCost = products[n].Cost;
                    }
                }

                for (int n = 0;n < people.Count; n++)
                {
                    if (people[n].Name == currentPerson)
                    {
                        if (people[n].Money - currentProductCost >= 0)
                        {
                            Product product = new Product(currentProduct, currentProductCost);

                            Console.WriteLine($"{people[n].Name} bought {currentProduct}");
                            people[n].Money -= currentProductCost;
                            people[n].Product.Add(product);
                        }
                        else
                        {
                            Console.WriteLine($"{people[n].Name} can't afford {currentProduct}");
                        }
                    }
                }
            }

            PrintPeopleWithTheirBoughtProducts(people);
        }

        static void AddingPeople(List<Person> people,string[] initialPeople)
        {
            for (int n = 0; n < initialPeople.Length; n++)
            {
                string[] personData = initialPeople[n].Split('=');

                string personName = personData[0];
                decimal personMoney = decimal.Parse(personData[1]);

                Person person = new Person(personName, personMoney);

                people.Add(person);
            }
        }

        static void AddingProducts(List<Product> products, string[] initialProducts)
        {
            for (int n = 0; n < initialProducts.Length; n++)
            {
                string[] productData = initialProducts[n].Split('=');

                string productName = productData[0];
                decimal productCost = decimal.Parse(productData[1]);

                Product product = new Product(productName, productCost);

                products.Add(product);
            }
        }

        static void PrintPeopleWithTheirBoughtProducts(List<Person> people)
        {
            foreach (var person in people)
            {
                if (person.Product.Count > 0)
                {
                    List<string> productNames = new List<string>();
                    foreach (var product in person.Product)
                    {
                        productNames.Add(product.Name);
                    }

                    Console.WriteLine($"{person.Name} - {string.Join(", ", productNames)}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
            }
        }
    }

    public class  Person 
    {

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            Product = new List<Product>();
        }

        public string Name { get; set; }

        public decimal Money { get; set; }

        public List<Product> Product { get; set; }
    }

    public class Product
    {

        public Product(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }

        public string Name { get; set; }

        public decimal Cost { get; set; }
    }
}