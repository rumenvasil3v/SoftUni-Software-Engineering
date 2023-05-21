using System;

namespace _06._Flower_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Make variable for numbers magnolias.
            int magnolias = int.Parse(Console.ReadLine());
            //2. Make variable for numbers hyacinths.
            int hyacinths = int.Parse(Console.ReadLine());
            //3. Make variable for numbers roses.
            int roses = int.Parse(Console.ReadLine());
            //4. Make variable for numbers cacti.
            int cacti = int.Parse(Console.ReadLine());
            //5. Make variable for price for gift.
            double gift = double.Parse(Console.ReadLine());
            //6. Calculate the price for magnolias.
            double magnoliasPrice = magnolias * 3.25;
            //7. Calculate the price for hyacinths.
            double hyacinthsPrice = hyacinths * 4;
            //8. Calculate the price for roses.
            double rosesPrice = roses * 3.50;
            //9. Calculate the price for cacti.
            double cactiprice = cacti * 8;
            //10. Calculate the price for flowers also we need to pay 5% tax from the flowers price.
            double flowersPrice = magnoliasPrice + hyacinthsPrice +  rosesPrice + cactiprice;
            flowersPrice = flowersPrice - flowersPrice * 0.05;
            //11. Conditional statement if the flower price is >= from the gift ->
            // print "She is left with {left money} leva."
            double leftMoney = flowersPrice - gift;
            //12. Conditional statement if the flower price is < from the gift ->
            // print "She will have to borrow {need money} leva."
            double neededMoney = gift - flowersPrice;

            if (flowersPrice >= gift)
            {
                Console.WriteLine($"She is left with {Math.Floor(leftMoney)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(neededMoney)} leva.");
            }
        }
    }
}
