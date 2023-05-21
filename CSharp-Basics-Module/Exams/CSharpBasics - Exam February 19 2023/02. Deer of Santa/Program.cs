using System;

namespace _02._Deer_of_Santa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysSantaAbsent = int.Parse(Console.ReadLine());
            int leftFoodKg = int.Parse(Console.ReadLine());
            double firstDearFood = double.Parse(Console.ReadLine());
            double secondDearFood = double.Parse(Console.ReadLine());
            double thirdDearFood = double.Parse(Console.ReadLine());

            firstDearFood = daysSantaAbsent * firstDearFood;
            secondDearFood = secondDearFood * daysSantaAbsent;
            thirdDearFood = daysSantaAbsent * thirdDearFood;

            double needFood = firstDearFood + secondDearFood + thirdDearFood;

            if (needFood < leftFoodKg)
            {
                Console.WriteLine($"{Math.Floor(leftFoodKg - needFood)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(needFood - leftFoodKg)} more kilos of food are needed.");
            }
        }
    }
}
