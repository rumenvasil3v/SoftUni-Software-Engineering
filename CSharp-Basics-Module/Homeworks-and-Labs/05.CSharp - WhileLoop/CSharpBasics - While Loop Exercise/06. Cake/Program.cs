using System;

namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenghtCake = int.Parse(Console.ReadLine());
            int widthCake = int.Parse(Console.ReadLine());

            int numCake = lenghtCake * widthCake;

            string input;
            while (true)
            {
                if (numCake < 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(numCake)} pieces more.");
                    break;
                }
                input = Console.ReadLine();
                
                if (input == "STOP")
                {
                    break;
                }
                numCake -= int.Parse(input);
            }

            if (numCake >= 0)
            {
                Console.WriteLine($"{numCake} pieces are left.");
            }
        }
    }
}
