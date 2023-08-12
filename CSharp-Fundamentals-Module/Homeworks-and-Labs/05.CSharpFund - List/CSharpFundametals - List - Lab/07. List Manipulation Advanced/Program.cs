using System;
using System.Collections.Generic;
using System.Linq;
/*
 5 34 678 67 5 563 98
Contains 23
PrintOdd
GetSum
Filter >= 21
end
 */
namespace _07._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console
                .ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();
            List<string> items = input.Split().ToList();
            bool makeChange = false;

            while (input != "end")
            {
                switch (items[0])
                {
                    case "Add":
                        int addNumber = int.Parse(items[1]);
                        makeChange = true;
                        numbers.Add(addNumber);
                        break;
                    case "Remove":
                        int removeNumber = int.Parse(items[1]);
                        makeChange = true;
                        numbers.Remove(removeNumber);
                        break;
                    case "RemoveAt":
                        int removeAtCurrentIndexNumber = int.Parse(items[1]);
                        makeChange = true;
                        numbers.RemoveAt(removeAtCurrentIndexNumber);
                        break;
                    case "Insert":
                        int insertNumber = int.Parse(items[1]);
                        int insertNumberIndex = int.Parse(items[2]);
                        makeChange = true;
                        numbers.Insert(insertNumberIndex, insertNumber);
                        break;
                    case "Contains":
                        int containNumber = int.Parse(items[1]);
                        if (numbers.Contains(containNumber))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        List<int> evenNumbers = new List<int>();
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 0)
                            {
                                evenNumbers.Add(numbers[i]);
                            }
                        }
                        Console.WriteLine(string.Join(' ', evenNumbers));
                        break;
                    case "PrintOdd":
                        List<int> oddNumbers = new List<int>();
                        foreach (int oddNums in numbers)
                        {
                            if (oddNums % 2 == 1)
                            {
                                oddNumbers.Add(oddNums);
                            }
                        }

                        Console.WriteLine(string.Join(' ', oddNumbers));
                        break;
                    case "GetSum":
                        int totalSumOfNumbers = numbers.Sum();
                        Console.WriteLine(totalSumOfNumbers);
                        break;
                    case "Filter":
                        string condition = items[1];
                        int conditionNumber = int.Parse(items[2]);
                        if (items[1] == ">")
                        {
                            List<int> greaterNumbers = new List<int>();
                            foreach (int number in numbers)
                            {
                                if (number > int.Parse(items[2]))
                                {
                                    greaterNumbers.Add(number);
                                }
                            }
                            Console.WriteLine(string.Join(' ', greaterNumbers));
                        }
                        else if (items[1] == "<")
                        {
                            List<int> lowerNumbers = new List<int>();
                            foreach (int number in numbers)
                            {
                                if (number < int.Parse(items[2]))
                                {
                                    lowerNumbers.Add(number);
                                }
                            }
                            Console.WriteLine(string.Join(' ', lowerNumbers));
                        }
                        else if (items[1] == ">=")
                        {
                            List<int> greaterAndInclusiveNumbers = new List<int>();
                            foreach (int number in numbers)
                            {
                                if (number >= int.Parse(items[2]))
                                {
                                    greaterAndInclusiveNumbers.Add(number);
                                }
                            }
                            Console.WriteLine(string.Join(' ', greaterAndInclusiveNumbers));
                        }
                        else if (items[1] == "<=")
                        {
                            List<int> lowerAndInclusiveNumbers = new List<int>();
                            foreach (int number in numbers)
                            {
                                if (number <= int.Parse(items[2]))
                                {
                                    lowerAndInclusiveNumbers.Add(number);
                                }
                            }
                            Console.WriteLine(string.Join(' ', lowerAndInclusiveNumbers));
                        }
                        break;
                }

                input = Console.ReadLine();
                items = input.Split().ToList();
            }

            if (makeChange)
            {
                Console.WriteLine(string.Join(' ', numbers));
            }
        }
    }
}
