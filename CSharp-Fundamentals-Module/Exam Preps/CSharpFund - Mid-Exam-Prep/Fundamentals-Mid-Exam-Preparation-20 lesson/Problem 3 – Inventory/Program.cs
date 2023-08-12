using System;
using System.Collections.Generic;
using System.Linq;
/*
Iron, Wood, Sword 
Collect - Gold 
Drop - Wood 
Craft! 

 */
namespace Problem_3___Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string input;
            while ((input = Console.ReadLine()) != "Craft!")
            {
                List<string> arguments = input.Split(" - ", StringSplitOptions.RemoveEmptyEntries).ToList();

                switch (arguments[0])
                {
                    case "Collect":
                        string addItem = arguments[1];
                        if (items.Contains(addItem))
                        {
                            continue;
                        }
                        items.Add(addItem);
                        break;
                    case "Drop":
                        string removeItem = arguments[1];
                        if (items.Contains(removeItem))
                        {
                            items.Remove(removeItem);
                        }
                        break;
                    case "Combine Items":
                        string[] tokens = arguments[1].Split(":", StringSplitOptions.RemoveEmptyEntries);
                        string oldItem = tokens[0];
                        string newItem = tokens[1];

                        if (items.Contains(oldItem))
                        {
                            for (int i = 0; i < items.Count; i++)
                            {
                                if (items[i] == oldItem)
                                {
                                    items.Insert(i + 1, newItem);
                                }
                            }
                        }
                        break;
                    case "Renew":
                        string renewItem = arguments[1];
                        if (items.Contains(renewItem))
                        {
                            items.Remove(renewItem);
                            items.Add(renewItem);
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", items));
        }
    }
}