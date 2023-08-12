using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            ListManipulator(numbers);
        }

        static void ListManipulator(List<int> numbers)
        {
            string input = Console.ReadLine();
            while(input != "end")
            {
                List<string> items = input.Split().ToList();
                switch (items[0])
                {
                    case "Delete":
                        DeleteElement(items, numbers);
                        break;
                    case "Insert":
                        InsertElement(items, numbers);
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', numbers));
        }

        static void DeleteElement(List<string> items, List<int> numbers)
        {
            int deleteElement = int.Parse(items[1]);
            for (int number = 0; number < numbers.Count; number++)
            {
                if (numbers[number] == deleteElement)
                {
                    numbers.Remove(deleteElement);
                }
            }
        }

        static void InsertElement(List<string> items, List<int> numbers)
        {
            int insertElement = int.Parse(items[1]);
            int insertElementPosition = int.Parse(items[2]);
            numbers.Insert(insertElementPosition, insertElement);
        }
    }
}
