using System;

namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstCharacter = char.Parse(Console.ReadLine());
            char secondCharacter = char.Parse(Console.ReadLine());

            AllCharactersBetweenTheseTwo(firstCharacter, secondCharacter);
        }

        static void AllCharactersBetweenTheseTwo(char firstCharacter, char secondCharacter)
        {
            string characters = string.Empty;;
            char firstCharacterSwap = firstCharacter;
            char secondCharacterSwap = secondCharacter;

            if (secondCharacter < firstCharacter)
            {
                secondCharacter = firstCharacterSwap;
                firstCharacter = secondCharacterSwap;
            }

            for (int i = firstCharacter + 1; i < secondCharacter; i++)
            {
                characters += (char)i + " ";
            }
            ;
            
            Console.WriteLine(characters);
        }
    }
}