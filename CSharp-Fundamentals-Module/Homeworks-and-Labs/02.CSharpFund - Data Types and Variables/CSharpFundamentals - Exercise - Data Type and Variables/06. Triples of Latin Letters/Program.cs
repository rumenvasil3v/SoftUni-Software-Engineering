using System;

namespace _06._Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine()) + 96;

            for (int a = 97; a <= number; a++)
            {
                for (int b = 97; b <= number; b++)
                {
                    for (int c = 97; c <= number; c++)
                    {
                        char firstChar = (char)a;
                        char secondChar = (char)b;
                        char thirdChar = (char)c;
                        
                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                    }
                }
            }
        }
    }
}
