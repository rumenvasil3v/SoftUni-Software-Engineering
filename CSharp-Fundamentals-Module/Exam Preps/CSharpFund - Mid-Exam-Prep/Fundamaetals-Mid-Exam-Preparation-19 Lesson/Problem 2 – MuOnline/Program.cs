using System;
using System.Linq;
using System.Threading;
/*
 rat 10|bat 20|potion 10|rat 10|chest 100|boss 70|chest 1000
 */
namespace Problem_2___MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int initialHealth = 100;
            int initialBitcoins = 0;
            bool isDead = false;

            string[] dungeonRooms = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < dungeonRooms.Length; i++)
            {
                if (isDead)
                {
                    break;
                }

                int bestRoom = i + 1;
                string currentRoom = dungeonRooms[i];
                string[] arguments = currentRoom.Split(' ');

                switch (arguments[0])
                {
                    case "potion":
                        int amountOfHealing = int.Parse(arguments[1]);

                        if (initialHealth + amountOfHealing > 100)
                        {
                            Console.WriteLine($"You healed for {100 - initialHealth} hp.");
                            initialHealth = 100;
                            Console.WriteLine($"Current health: {initialHealth} hp.");
                            break;
                        }

                        initialHealth += amountOfHealing;
                        Console.WriteLine($"You healed for {amountOfHealing} hp.");
                        Console.WriteLine($"Current health: {initialHealth} hp.");
                        break;
                    case "chest":
                        int amountOfBitcoints = int.Parse(arguments[1]);
                        initialBitcoins += amountOfBitcoints;
                        Console.WriteLine($"You found {amountOfBitcoints} bitcoins.");
                        break;
                    default:
                        int attackOfTheMonster = int.Parse(arguments[1]);
                        initialHealth -= attackOfTheMonster;
                        if (initialHealth > 0)
                        {
                            Console.WriteLine($"You slayed {arguments[0]}.");
                        }
                        else
                        {
                            Console.WriteLine($"You died! Killed by {arguments[0]}.");
                            Console.WriteLine($"Best room: {bestRoom}");
                            isDead = true;
                        }
                        break;
                }
            }

            if (!isDead)
            {
                Console.WriteLine($"You've made it!");
                Console.WriteLine($"Bitcoins: {initialBitcoins}");
                Console.WriteLine($"Health: {initialHealth}");
            }
        }
    }
}