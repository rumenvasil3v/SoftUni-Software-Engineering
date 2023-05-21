using System;

namespace _03._Animal_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();


            if (animal == "dog")
            {
                Console.WriteLine("mammal");
            }
            else if (animal == "snake")
            {
                Console.WriteLine("reptile");
            }
            else if (animal == "crocodile")
            {
                Console.WriteLine("reptile");
            }
            else if (animal == "tortoise")
            {
                Console.WriteLine("reptile");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
