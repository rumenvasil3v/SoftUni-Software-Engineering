using System;

namespace _05._Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Variable for number of days.
            int days = int.Parse(Console.ReadLine());
            //2. Variable for lefted food in kg.
            int food = int.Parse(Console.ReadLine());
            //3. Variable for food per day for the dog in kg.
            double foodForDog = double.Parse(Console.ReadLine());
            //4. Variable for food per day for the cat in kg.
            double foodForCat = double.Parse(Console.ReadLine());
            //5. Variable for food per day for the turtle in gr.
            double foodForTurtle = double.Parse(Console.ReadLine());

            //6. Calculate the food the dog eat for days.
            double foodDogEat = foodForDog * days;
            //7. Calculate the food the cat eat for days.
            double foodCatEat = foodForCat * days;
            //8. Calculate the food the turtle eat for days.
            double foodTurtleEat = (foodForTurtle / 1000) * days;
            //9. Calculate the food for animals which they eat for days.
            double foodForAnimals = foodDogEat + foodCatEat + foodTurtleEat;
            //10. Conditional statement if the food is >= from foodForAnimals ->
            // print "{left food} kilos of food left."
            double leftFood = food - foodForAnimals;
            //11. Conditional statement if the food is < foodForAnimals ->
            // print "{foodNeeded} more kilos of food are needed."
            double foodNeeded = foodForAnimals - food;

            if (food >= foodForAnimals)
            {

                Console.WriteLine($"{Math.Floor(leftFood)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(foodNeeded)} more kilos of food are needed.");
            }
        }
    }
}
