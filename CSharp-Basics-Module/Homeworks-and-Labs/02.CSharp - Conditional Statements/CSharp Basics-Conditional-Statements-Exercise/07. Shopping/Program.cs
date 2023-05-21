using System;

namespace _07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Четем от конзолата:
            //Бюджетът на Петър - реално число в интервала [0.0…100000.0]
            double budget = double.Parse(Console.ReadLine());
            //Броят видеокарти - цяло число в интервала[0…100]
            int videoCards = int.Parse(Console.ReadLine());
            //Броят процесори - цяло число в интервала[0…100]
            int processors = int.Parse(Console.ReadLine());
            //Броят рам памет -цяло число в интервала[0…100]
            int RAM = int.Parse(Console.ReadLine());

            //2. Пресмятаме цените на видеокартите 
            int videoCardsPrice = videoCards * 250;
            //3. Пресмятаме цените на процесора и рам паметта
            double processorsPrice = videoCardsPrice * 0.35;
            processorsPrice = processors * processorsPrice;

            double ramPrice = videoCardsPrice * 0.10;
            ramPrice = RAM * ramPrice;
            //4. Намираме крайната сметка.
            double techSum = videoCardsPrice + processorsPrice + ramPrice;
            //5. Проверяваме дали броя на видеокартите > процесора 
            // => -15 % от крайната сметка
            if (videoCards > processors)
            {
                techSum = techSum - techSum * 0.15;
                
            }
             
            //6. Проверяваме дали бюджета ще му стигне.
            // бюджета > крайната сметка (=> ще му остане от бюджета)
            // бюджета < крайната сметка (=> трябват му определена сума)
            if (budget >= techSum)
            {
                Console.WriteLine($"You have {budget - techSum:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {techSum - budget:f2} leva more!");
            }
        }
    }
}
