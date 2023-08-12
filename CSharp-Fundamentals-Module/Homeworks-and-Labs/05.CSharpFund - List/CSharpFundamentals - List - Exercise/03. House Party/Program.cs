using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            CountOfGuests(numberOfCommands);
        }

        static void CountOfGuests(int numberOfGuests)
        {

            bool notInList = true;
            bool inList = false;
            List<string> guests = new List<string>();
            for (int i = 0; i < numberOfGuests; i++)
            {
                string guest = Console.ReadLine();
                List<string> items = guest.Split().ToList();
                string name = items[0];

                if (guest == $"{name} is going!")
                {
                    GuestIsGoing(name, guests, inList);
                }
                else if (guest == $"{name} is not going!")
                {
                    GuestIsNotGoing(name, guests, notInList);
                }

                inList = false;
                notInList = true;
            }

            PrintAllGuests(guests);
        }

        static void GuestIsGoing(string name, List<string> guests, bool inList)
        {
            if (guests.Count == 0)
            {
                guests.Add(name);
            }
            else
            {
                for (int j = 0; j < guests.Count; j++)
                {
                    if (guests[j] == name)
                    {
                        inList = true;
                        break;
                    }
                }

                if (inList)
                {
                    Console.WriteLine($"{name} is already in the list!");
                }
                else
                {
                    guests.Add(name);
                }
            }
        }

        static void GuestIsNotGoing(string name, List<string> guests, bool notInList)
        {
            for (int j = 0; j < guests.Count; j++)
            {
                if (guests[j] == name)
                {
                    notInList = false;
                    guests.RemoveAt(j);
                    break;
                }
            }

            if (notInList)
            {
                Console.WriteLine($"{name} is not in the list!");
            }
        }

        static void PrintAllGuests(List<string> guests)
        {
            foreach (string guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
