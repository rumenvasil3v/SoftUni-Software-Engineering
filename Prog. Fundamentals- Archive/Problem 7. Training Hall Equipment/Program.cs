/*
2000
4
whiteboard
150
1
marker
6.99
10
chalk
0.50
20
beanbag chair
119.99
15

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Training_Hall_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int numberOfItems = int.Parse(Console.ReadLine());

            decimal itemsSubtotal = 0;
            bool notEnoughMoney = false;
            decimal moneyNeeding = 0;

            for (int n = 1; n <= numberOfItems; n++)
            {
                string itemName = Console.ReadLine();
                decimal itemPrice = decimal.Parse(Console.ReadLine());
                int itemQuantity = int.Parse(Console.ReadLine());

                if (itemQuantity > 1)
                {
                    Console.WriteLine($"Adding {itemQuantity} {itemName}s to cart.");
                }
                else
                {
                    Console.WriteLine($"Adding {itemQuantity} {itemName} to cart.");
                }

                itemsSubtotal += itemPrice * itemQuantity;
                budget -= itemPrice * itemQuantity;
                if (budget < 0)
                {
                    moneyNeeding = budget;
                    notEnoughMoney = true;
                    break;
                }
            }

            Console.WriteLine($"Subtotal: ${itemsSubtotal:f2}");

            if (notEnoughMoney)
            {
                Console.WriteLine($"Not enough. We need ${Math.Abs(moneyNeeding):f2} more.");
            }
            else
            {
                Console.WriteLine($"Money left: ${budget:f2}");
            }
        }
    }
}
