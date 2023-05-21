using System;

namespace _03._Harvest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. We read from the console X square meters vineyard.
            int vineyard = int.Parse(Console.ReadLine());
            //2. We read from the console Y grape  for one square meter.
            double grape = double.Parse(Console.ReadLine());
            //3. We read from the console Z needed liters wine.
            int wine = int.Parse(Console.ReadLine());
            //4. We read from the console number of the workers.
            int workers = int.Parse(Console.ReadLine());
            //5. We calculate vineyard with the grape for one square meter to see haw many kg grape we have.
            double kgGrape = vineyard * grape;
            //6. Calulating how much wine is produced, like we calculate kg grape with 2.5 kg grape for one liter wine and 40% from the vineyard which are for the wine yard.
            double wineProduced = 0.4 * (kgGrape / 2.5);
            //7. Declare variable for how much liters wine are left.
            double litersLeft = wineProduced - wine;
            //8. Conditional statement if the needed wine is more than the wine produced ->
            // print "It will be a tough winter! More {wine liters} liters wine needed."
            if (wineProduced < wine)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(wine - wineProduced)} liters wine needed.");
            }
            //9. Conditional statement if the produced wine is more than the needed wine ->
            // print "Good harvest this year! Total wine: {produced wine} liters."
            // print "{left liters} liters left -> {liter for one worker} liters per person."
            if (wineProduced >= wine) 
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wineProduced)} liters.");
                Console.WriteLine($"{Math.Ceiling(litersLeft)} liters left -> {Math.Ceiling(litersLeft / workers)} liters per person.");
            }
        }
    }
}
