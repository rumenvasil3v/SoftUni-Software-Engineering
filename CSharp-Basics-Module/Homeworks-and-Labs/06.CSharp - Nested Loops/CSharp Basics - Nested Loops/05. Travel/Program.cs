using System;

namespace _05._Travel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Make variables for:
            // - entrance from the console
            string input = Console.ReadLine();
            // - destination
            string destination;
            // - need budget
            double budget;

            //3. Create while loop, which will execute, while entrance != "End"
            while (input != "End")
            {
                destination = input;
                budget = double.Parse(Console.ReadLine());

                // => Create inside while loop,  which will execute, while she doesn't save enough
                while (budget > 0) 
                {
                    budget -= double.Parse(Console.ReadLine());
                }
                // ==> изваждаме от необходимия буджет парите, които спестява

                // => After she saves enough money for the destination - print:
                Console.WriteLine($"Going to {destination}!");

                input = Console.ReadLine();
            }
        }
    }
}
