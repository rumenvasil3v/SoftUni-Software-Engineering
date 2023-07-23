using System;
using System.Linq;
using System.Security.Cryptography;

/*
 1 10 100 1000
exchange 3
first 2 odd
last 4 odd
end

 */
namespace _11._Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] initialArrays = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string input = Console.ReadLine();
            ArrayManipulatorCommand(input, initialArrays);
        }

        static void ArrayManipulatorCommand(string input, int[] initialArrays)
        {
            int[] exchangedArray = new int[initialArrays.Length];
            exchangedArray = initialArrays;

            while (input != "end")
            {
                string[] items = input.Split(' ');
                bool isValid = int.TryParse(items[1], out int index);
                isValid = int.TryParse(items[1], out int count);

                if (input == "max odd" || input == "max even")
                {
                    MaxEvenOrOdd(exchangedArray, input);
                }
                else if (input == "min odd" || input == "min even")
                {
                    MinEvenOrOdd(exchangedArray, input);
                }
                else if (input == $"first {count} even" || input == $"first {count} odd")
                {
                    FirstCountEvenOrOdd(exchangedArray, count, input);
                }
                else if (input == $"last {count} even" || input == $"last {count} odd")
                {
                    LastCountEvenOrOdd(exchangedArray, count, input);
                }
                else if (input == $"exchange {index}")
                {
                    exchangedArray = ExchangeArrayIndex(exchangedArray, input, index);
                }

                input = Console.ReadLine();
            }

            if (input == "end")
            {
                FinalResult(exchangedArray);
            }
        }

        static int[] ExchangeArrayIndex(int[] exchangedArray, string input, int index)
        {
            if (index > exchangedArray.Length - 1)
            {
                Console.WriteLine("Invalid index");
                return exchangedArray;
            }

            int mid = index + 1;

            int[] firstHalf = exchangedArray.Take(mid).ToArray();
            int[] secondHalf = exchangedArray.Skip(mid).ToArray();

            exchangedArray = secondHalf.Concat(firstHalf).ToArray();

            return exchangedArray;
        }

        static void MaxEvenOrOdd(int[] exchangedArray, string input)
        {
            int maxEven = 0;
            int currentEven = 0;
            int maxOdd = 0;
            int currentOdd = 0;
            bool isFound = false;

            if (input == "max even")
            {
                for (int i = 0; i < exchangedArray.Length; i++)
                {
                    if (exchangedArray[i] % 2 == 0)
                    {
                        isFound = true;

                        if (exchangedArray[i] == currentEven)
                        {
                            maxEven = i;
                        }

                        if (exchangedArray[i] > currentEven)
                        {
                            currentEven = exchangedArray[i];
                            maxEven = i;
                        }
                    }
                }

                if (isFound)
                {
                    Console.WriteLine(maxEven);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
            else if (input == "max odd")
            {
                for (int i = 0; i < exchangedArray.Length; i++)
                {
                    if (exchangedArray[i] % 2 == 1)
                    {
                        isFound = true;

                        if (exchangedArray[i] == currentOdd)
                        {
                            maxOdd = i;
                        }

                        if (exchangedArray[i] > currentOdd)
                        {
                            currentOdd = exchangedArray[i];
                            maxOdd = i;
                        }
                    }
                }

                if (isFound)
                {
                    Console.WriteLine(maxOdd);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
        }

        static void MinEvenOrOdd(int[] exchangedArray, string input)
        {
            int minEven = 0;
            int currentEven = int.MaxValue;
            int minOdd = 0;
            int currentOdd = int.MaxValue;
            bool isFound = false;

            if (input == "min even")
            {
                for (int i = 0; i < exchangedArray.Length; i++)
                {
                    if (exchangedArray[i] % 2 == 0)
                    {
                        isFound = true;

                        if (exchangedArray[i] == currentEven)
                        {
                            minEven = i;
                        }

                        if (currentEven > exchangedArray[i])
                        {
                            currentEven = exchangedArray[i];
                            minEven = i;
                        }
                    }
                }

                if (isFound)
                {
                    Console.WriteLine(minEven);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
            else if (input == "min odd")
            {
                for (int i = 0; i < exchangedArray.Length; i++)
                {
                    if (exchangedArray[i] % 2 == 1)
                    {
                        isFound = true;

                        if (exchangedArray[i] == currentOdd)
                        {
                            minOdd = i;
                        }

                        if (currentOdd > exchangedArray[i])
                        {
                            currentOdd = exchangedArray[i];
                            minOdd = i;
                        }
                    }
                }

                if (isFound)
                {
                    Console.WriteLine(minOdd);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
        }

        static void FirstCountEvenOrOdd(int[] exchangedArray, int count, string input)
        {
            string[] firstEvenElements = new string[count];
            string[] firstOddElements = new string[count];
            int currentEvenCount = 0;
            int currentOddCount = 0;
            bool isFound = false;

            if (input == $"first {count} even")
            {
                for (int i = 0; i < exchangedArray.Length; i++)
                {

                    if (count > exchangedArray.Length)
                    {
                        Console.WriteLine("Invalid count");
                        return;
                    }

                    if (exchangedArray[i] % 2 == 0)
                    {
                        isFound = true;

                        currentEvenCount++;
                        firstEvenElements[i] += exchangedArray[i];

                        if (currentEvenCount == count)
                        {
                            break;
                        }
                    }
                }

                if (currentEvenCount == 1)
                {
                    Console.WriteLine($"[{string.Join(", ", firstEvenElements.Length - 1)}]");
                    return;
                }

                if (isFound)
                {
                    Console.WriteLine($"[{string.Join(", ", firstEvenElements)}]");
                }
                else
                {
                    Console.WriteLine("[]");
                }
            }
            else if (input == $"first {count} odd")
            {
                for (int i = 0; i < exchangedArray.Length; i++)
                {

                    if (count > exchangedArray.Length)
                    {
                        Console.WriteLine("Invalid count");
                        return;
                    }

                    if (exchangedArray[i] % 2 == 1)
                    {
                        isFound = true;

                        currentOddCount++;
                        firstOddElements[i] += exchangedArray[i];

                        if (currentOddCount == count)
                        {
                            break;
                        }
                    }
                }

                if (currentOddCount == 1)
                {
                    Console.WriteLine($"[{string.Join(", ", firstOddElements.Length - 1)}]");
                    return;
                }

                if (isFound)
                {
                    Console.WriteLine($"[{string.Join(", ", firstOddElements.Length )}]");
                }
                else
                {
                    Console.WriteLine("[]");
                }
            }
        }

        static void LastCountEvenOrOdd(int[] exchangedArray, int count, string input)
        {
            string[] lastEvenElements = new string[count];
            string[] lastOddElements = new string[count];
            int currentEvenElements = 0;
            int currentOddElements = 0;
            bool isFound = false;

            if (input == $"last {count} even")
            {

                for (int i = exchangedArray.Length - 1; i >= 0; i--)
                {

                    if (count > exchangedArray.Length)
                    {
                        Console.WriteLine("Invalid count");
                        return;
                    }

                    if (exchangedArray[i] % 2 == 0)
                    {
                        isFound = true;

                        currentEvenElements++;
                        lastEvenElements[i] += exchangedArray[i];

                        if (currentEvenElements == count)
                        {
                            break;
                        }
                    }
                }

                if (currentEvenElements == 1)
                {
                    Console.WriteLine($"[{string.Join(", ", lastEvenElements.Length - 1)}]");
                    return;
                }

                if (isFound)
                {
                    Console.WriteLine($"[{string.Join(", ", lastEvenElements)}]");
                }
                else
                {
                    Console.WriteLine("[]");
                }
            }
            else if (input == $"last {count} odd")
            {

                for (int i = exchangedArray.Length - 1; i >= 0; i--)
                {

                    if (count > exchangedArray.Length)
                    {
                        Console.WriteLine("Invalid count");
                        return;
                    }

                    if (exchangedArray[i] % 2 == 1)
                    {
                        isFound = true;

                        currentOddElements++;
                        lastOddElements[i] += exchangedArray[i];

                        if (currentOddElements == count)
                        {
                            break;
                        }
                    }
                }

                if (currentOddElements == 1)
                {
                    Console.WriteLine($"[{string.Join(", ", lastOddElements.Length - 1)}]");
                    return;
                }

                if (isFound)
                {
                    Console.WriteLine($"[{string.Join(", ", lastOddElements)}]");
                }
                else
                {
                    Console.WriteLine("[]");
                }
            }
        }

        static void FinalResult(int[] exchangedArray)
        {
            string[] finalState = new string[exchangedArray.Length];

            for (int i = 0; i < exchangedArray.Length; i++)
            {
                if (i == exchangedArray.Length - 1)
                {
                    finalState[i] += exchangedArray[i];
                }
                else
                {
                    finalState[i] += exchangedArray[i];
                }
            }

            Console.WriteLine($"[{string.Join(", ", finalState)}]");
        }
    }
}