using System;
/*
 We are placing N orders at a time. You need to calculate the price with the following formula:

                        ((daysInMonth * capsulesCount) * pricePerCapsule)

1
1.53
30
8

2
4.99
31
3
0.35
31
5

1
9.223
31
433
 */
namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfOrders = int.Parse(Console.ReadLine());

            double pricePerOrder = 0;
            double totalPrice = 0;

            for (int i = 1; i <= countOfOrders; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsuleCount = int.Parse(Console.ReadLine());

                pricePerOrder = (days * capsuleCount) * pricePerCapsule;
                totalPrice += pricePerOrder;

                Console.WriteLine($"The price for the coffee is: ${pricePerOrder:F2}");
            }

            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
