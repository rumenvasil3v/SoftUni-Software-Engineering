using System;
using System.Collections.Generic;
using System.Linq;
/*
1 23 29 18 43 21 20
Add 5
Remove 5
Shift left 3
Shift left 1
End

5 12 42 95 32 1
Shift right 11
End
Insert 3 0
Remove 10
Insert 8 6
Shift right 1
Shift left 2
End
 */
namespace _04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console
                .ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            ListOperations(numbers);
        }

        static void ListOperations(List<int> numbers)
        {
            string input = Console.ReadLine();
            while (input != "End")
            {
                List<string> items = input.Split().ToList();

                switch (items[0])
                {
                    case "Add":
                        int addingNumber = int.Parse(items[1]);
                        numbers = AddingNumber(addingNumber, numbers);
                        break;
                    case "Insert":
                        int insertNumber = int.Parse(items[1]);
                        int insertNumberindex = int.Parse(items[2]);
                        numbers = InsertNumber(insertNumber, insertNumberindex, numbers);
                        break;
                    case "Remove":
                        int removeNumberIndex = int.Parse(items[1]);
                        numbers = RemoveNumberAtIndex(removeNumberIndex, numbers);
                        break;
                    case "Shift":
                        switch (items[1])
                        {
                            case "left":
                                int countNumberLeft = int.Parse(items[2]);
                                numbers = ShiftLeftNumber(countNumberLeft, numbers);
                                break;
                            case "right":
                                int countNumberRight = int.Parse(items[2]);
                                numbers = ShiftRightNumber(countNumberRight, numbers);
                                break;
                        }
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', numbers));
        }

        static List<int> AddingNumber(int addingNumber, List<int> numbers)
        {
            numbers.Add(addingNumber);

            return numbers;
        }

        static List<int> InsertNumber(int insertNumber, int insertNumberIndex, List<int> numbers)
        {
            bool isInvalid = false;

            if (insertNumberIndex >= numbers.Count || insertNumberIndex < 0)
            {
                isInvalid = true;
            }

            if (isInvalid)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                numbers.Insert(insertNumberIndex, insertNumber);
            }

            return numbers;
        }

        static List<int> RemoveNumberAtIndex(int removeNumberIndex, List<int> numbers)
        {
            bool isInvalid = false;

            if (removeNumberIndex >= numbers.Count || removeNumberIndex < 0)
            {
                isInvalid = true;
            }

            if (isInvalid)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                numbers.RemoveAt(removeNumberIndex);
            }

            return numbers;
        }

        static List<int> ShiftLeftNumber(int countNumberLeft, List<int> numbers)
        {
            countNumberLeft %= numbers.Count;

            List<int> shiftedNumbers = numbers.GetRange(0, countNumberLeft);
            numbers.RemoveRange(0, countNumberLeft);
            numbers.InsertRange(numbers.Count, shiftedNumbers);

            return numbers;
        }

        static List<int> ShiftRightNumber(int countNumberRight, List<int> numbers)
        {
            countNumberRight %= numbers.Count;

            int lastIndex = numbers.Count - countNumberRight;
            List<int> shiftedNumbers = numbers.GetRange(lastIndex, countNumberRight);
            numbers.RemoveRange(lastIndex, countNumberRight);
            numbers.InsertRange(0, shiftedNumbers); 

            return numbers;
        }
    }
}
