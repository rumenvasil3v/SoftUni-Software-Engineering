using System;

namespace PlaceHolders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int years = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();

            Console.WriteLine("My name is {0} and I am {1} years old",name,years);// using placeholders with numbers {0} and {1}

            Console.WriteLine($"My name is {name} and I am {years:d2} years old.");
        }
    }
}
