using System;
using System.Linq;

namespace _01._The_Imitation_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();

            string input;
            while ((input = Console.ReadLine()) != "Decode")
            {
                string[] commands = input.Split("|");

                switch (commands[0])
                {
                    case "Move":
                        int moveCharacters = int.Parse(commands[1]);
                        string substring = encryptedMessage.Substring(0, moveCharacters);
                        encryptedMessage = encryptedMessage.Remove(0, moveCharacters);
                        encryptedMessage += substring;
                        break;
                    case "Insert":
                        int indexToInsert = int.Parse(commands[1]);
                        string characterToInsert = commands[2];
                        encryptedMessage = encryptedMessage.Insert(indexToInsert, characterToInsert);
                        break;
                    case "ChangeAll":
                        char characterToReplace = char.Parse(commands[1]); 
                        char newCharacter = char.Parse(commands[2]);
                        encryptedMessage = encryptedMessage.Replace(characterToReplace, newCharacter);
                        break;
                }
            }

            Console.WriteLine($"The decrypted message is: {encryptedMessage}");
        }
    }
}
