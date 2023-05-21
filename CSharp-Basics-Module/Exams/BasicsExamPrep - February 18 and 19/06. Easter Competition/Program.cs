using System;
using System.Runtime.InteropServices;

namespace _06._Easter_Competition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int easterBreads = int.Parse(Console.ReadLine());
            bool isValid = false;
            int evaluationFromOnePerson = int.MinValue;
            string bakerName= string.Empty;
            int currentPoints = 0;
            string  winner = string.Empty;

            for (int i = 1; i <= easterBreads; i++)
            {
                string baker = Console.ReadLine();
                bakerName = baker;
                while (baker != "Stop")
                {
                    baker  = Console.ReadLine();
                    if (baker == "Stop")
                    {
                        break;
                    }
                    currentPoints += int.Parse(baker);
                    if (currentPoints > evaluationFromOnePerson)
                    {
                        evaluationFromOnePerson = currentPoints;
                        winner = bakerName;
                    }
                    
                }
                Console.WriteLine($"{bakerName} has {currentPoints} points.");
                if (currentPoints == evaluationFromOnePerson)
                {
                    Console.WriteLine($"{bakerName} is the new number 1!");
                }
                
                currentPoints= 0;
            }
                Console.WriteLine($"{winner} won competition with {evaluationFromOnePerson} points! ");
        }
    }
}
