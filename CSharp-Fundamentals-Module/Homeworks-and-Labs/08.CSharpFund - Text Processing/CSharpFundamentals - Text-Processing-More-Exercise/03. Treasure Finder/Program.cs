/*
1 2 1 3
ikegfp'jpne)bv=41P83X@
ujfufKt)Tkmyft'duEprsfjqbvfv=53V55XA
find

 */

using System.Text;

namespace _03._Treasure_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console
                .ReadLine()
                .Split(' ')
                .Select(x => int.Parse(x))
                .ToArray();

            string decryptedMessage = string.Empty;

            int start = 0;

            string input;
            while ((input = Console.ReadLine()) != "find")
            {
                for (int t = 0; t < input.Length; t++)
                {

                    if (start == numbers.Length)
                    {
                        start = 0;
                    }

                    for (int n = start; n < numbers.Length; n++)
                    {
                        int currentNumber = numbers[n];
                        int number = input[t];

                        char currentChar = (char)(number - currentNumber);

                        decryptedMessage += currentChar;
                        
                        break;
                    }

                    start++;
                }

                int firstCharacterOfTreasure = decryptedMessage.IndexOf('&');
                int LastCharacterOfTreasure = decryptedMessage.LastIndexOf('&');

                string typeOfTreasure = decryptedMessage.Substring(firstCharacterOfTreasure + 1,
                    LastCharacterOfTreasure - firstCharacterOfTreasure - 1);

                int firstCharacterCoordinates = decryptedMessage.IndexOf('<');
                int lastCharacterCoordinates = decryptedMessage.LastIndexOf('>');

                string treasureCoordinates = decryptedMessage.Substring(firstCharacterCoordinates + 1,
                    lastCharacterCoordinates - firstCharacterCoordinates - 1);

                Console.WriteLine($"Found {typeOfTreasure} at {treasureCoordinates}");

                decryptedMessage = string.Empty;
                start = 0;
            }
        }
    }
}