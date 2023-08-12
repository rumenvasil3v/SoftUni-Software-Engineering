using System;

namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string productChoose = Console.ReadLine();
            ProductChoose(productChoose);
        }

        static void ProductChoose(string productChoose)
        {
            if (productChoose == "coffee")
            {
                double productQuantity = double.Parse(Console.ReadLine());
                ProductQuantity(productQuantity * 1.50);
            }
            else if (productChoose == "water")
            {
                double productQuantity = double.Parse(Console.ReadLine());
                ProductQuantity(productQuantity * 1.00);
            }
            else if (productChoose == "coke")
            {
                double productQuantity = double.Parse(Console.ReadLine());
                ProductQuantity(productQuantity * 1.40);
            }
            else if (productChoose == "snacks")
            {
                double productQuantity = double.Parse(Console.ReadLine());
                ProductQuantity(productQuantity * 2.00);
            }
        }

        static void ProductQuantity(double productQuantity)
        {
            double totalPrice = productQuantity;
            TotalProductPrice(totalPrice);
        }

        static void TotalProductPrice(double totalPrice)
        {
            Console.WriteLine("{0:F2}", totalPrice);
        }
    }
}
