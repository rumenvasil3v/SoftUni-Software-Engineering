using System;
using System.Security.Cryptography;

namespace _10._Lower_or_Upper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char randomCharacter = char.Parse(Console.ReadLine());

            if (randomCharacter >= 65 && randomCharacter <= 90)
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
