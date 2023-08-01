using System;
using System.Linq;
using System.Security.Cryptography;

/*
1 10 100 1000
exchange 3
first 2 odd
last 4 odd
end

2 3 3 3 5 7 9 2
exchange 1
min odd
min even
first 2 odd
last 2 even
exchange 3
end

1 3 5 7 9
exchange 1
max odd
min even
first 2 odd
last 2 even
exchange 3
end

1 10 100 1000
max even
first 5 even
exchange 10
min odd
exchange 0
max even
min even
end
 */
namespace _11._Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] initialArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            initialArray = ArrayManipulatorCommand(initialArray);
            Console.WriteLine($"[{string.Join(", ", initialArray)}]");
        }

        static int[] ArrayManipulatorCommand(int[] initialArray)
        {
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                switch (input.Split()[0])
                {
                    case "exchange":
                        int index = int.Parse(input.Split()[1]);

                        initialArray = ExchangeArrayIndex(initialArray, index);
                        break;
                    case "max":
                        MaxEvenOrOdd(initialArray, input);
                        break;
                    case "min":
                        MinEvenOrOdd(initialArray, input);
                        break;
                    case "first":
                        int firstCount = int.Parse(input.Split()[1]);

                        FirstEvenOrOddElements(initialArray, firstCount, input);
                        break;
                    case "last":
                        int lastCount = int.Parse(input.Split()[1]);

                        LastEvenOrOddElements(initialArray, lastCount, input);
                        break;
                }
            }

            return initialArray;
        }

        static int[] ExchangeArrayIndex(int[] initialArray, int index)
        {
            if (index > initialArray.Length - 1)
            {
                Console.WriteLine("Invalid index");
                return initialArray;
            }

            int[] firstHalf = initialArray.Take(index + 1).ToArray();
            int[] secondHalf = initialArray.Skip(index + 1).ToArray();

            initialArray = secondHalf.Concat(firstHalf).ToArray();

            return initialArray;
        }

        static void MaxEvenOrOdd(int[] initialArray, string input)
        {
            int maxIndex = 0;

            switch (input.Split()[1])
            {
                case "odd":
                    maxIndex = initialArray.Count(x => x % 2 == 1);
                    if (maxIndex > 0)
                    {
                        int maxOdd = 0;
                        int oddIndex = 0;
                        for (int n = 0; n < initialArray.Length; n++)
                        {
                            if (initialArray[n] % 2 == 1)
                            {
                                if (initialArray[n] > maxOdd)
                                {
                                    maxOdd = initialArray[n];
                                    oddIndex = n;
                                    continue;
                                }

                                if (maxOdd == initialArray[n])
                                {
                                    oddIndex = n;
                                    continue;
                                }
                            }
                        }

                        Console.WriteLine(oddIndex);
                    }
                    else
                    {
                        Console.WriteLine("No matches");
                    }
                    break;
                case "even":
                    maxIndex = initialArray.Count(x => x % 2 == 0);
                    if (maxIndex > 0)
                    {
                        int maxEven = 0;
                        int evenIndex = 0;
                        for (int n = 0; n < initialArray.Length; n++)
                        {
                            if (initialArray[n] % 2 == 0)
                            {
                                if (initialArray[n] > maxEven)
                                {
                                    maxEven = initialArray[n];
                                    evenIndex = n;
                                    continue;
                                }

                                if (maxEven == initialArray[n])
                                {
                                    evenIndex = n;
                                    continue;
                                }
                            }
                        }

                        Console.WriteLine(evenIndex);
                    }
                    else
                    {
                        Console.WriteLine("No matches");
                    }
                    break;
            }
        }

        static void MinEvenOrOdd(int[] initialArray, string input)
        {
            int minIndex = 0;

            switch (input.Split()[1])
            {
                case "odd":
                    int minOdd = int.MaxValue;
                    int oddIndex = 0;
                    minIndex = initialArray.Count(x => x % 2 == 1);
                    if (minIndex > 0)
                    {
                        for (int n = 0; n < initialArray.Length; n++)
                        {
                            if (initialArray[n] % 2 == 1)
                            {
                                if (initialArray[n] < minOdd)
                                {
                                    minOdd = initialArray[n];
                                    oddIndex = n;
                                    continue;
                                }

                                if (initialArray[n] == minOdd)
                                {
                                    oddIndex = n;
                                    continue;
                                }
                            }
                        }

                        Console.WriteLine(oddIndex);
                    }
                    else
                    {
                        Console.WriteLine("No matches");
                    }
                    break;
                case "even":
                    int minEven = int.MaxValue;
                    int evenIndex = 0;
                    minIndex = initialArray.Count(x => x % 2 == 0);
                    if (minIndex > 0)
                    {
                        for (int n = 0; n < initialArray.Length; n++)
                        {
                            if (initialArray[n] % 2 == 0)
                            {
                                if (initialArray[n] < minEven)
                                {
                                    minEven = initialArray[n];
                                    evenIndex = n;
                                    continue;
                                }

                                if (initialArray[n] == minEven)
                                {
                                    evenIndex = n;
                                    continue;
                                }
                            }
                        }

                        Console.WriteLine(evenIndex);
                    }
                    else
                    {
                        Console.WriteLine("No matches");
                    }
                    break;
            }
        }

        static void FirstEvenOrOddElements(int[] initialArray, int firstCount, string input)
        {
            int evenIndex = 0;
            int oddIndex = 0;
            int[] evenElements = new int[initialArray.Count(x => x % 2 == 0)];
            int[] oddElements = new int[initialArray.Count(x => x % 2 == 1)];

            for (int n = 0; n < initialArray.Length; n++)
            {
                if (initialArray[n] % 2 == 1)
                {
                    oddElements[oddIndex] = initialArray[n];
                    oddIndex++;
                }
                else
                {
                    evenElements[evenIndex] = initialArray[n];
                    evenIndex++;
                }
            }

            switch (input.Split()[2])
            {
                case "odd":
                    if (firstCount > initialArray.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        if (oddElements.Length > 0)
                        {
                            if (firstCount <= oddElements.Length)
                            {
                                Console.Write("[");
                                for (int n = 0; n < firstCount; n++)
                                {
                                    if (n == firstCount - 1)
                                    {
                                        Console.Write($"{oddElements[n]}");
                                        continue;
                                    }
                                    Console.Write($"{oddElements[n]}, ");
                                }
                                Console.WriteLine("]");
                            }
                            else
                            {
                                Console.WriteLine($"[{string.Join(", ", oddElements)}]");
                            }
                        }
                        else
                        {
                            Console.WriteLine("[]");
                        }
                    }
                    break;
                case "even":
                    if (firstCount > initialArray.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        if (evenElements.Length > 0)
                        {
                            if (firstCount <= evenElements.Length)
                            {
                                Console.Write("[");
                                for (int n = 0; n < firstCount; n++)
                                {
                                    if (n == firstCount - 1)
                                    {
                                        Console.Write($"{evenElements[n]}");
                                        continue;
                                    }
                                    Console.Write($"{evenElements[n]}, ");
                                }
                                Console.WriteLine("]");
                            }
                            else
                            {
                                Console.WriteLine($"[{string.Join(", ", evenElements)}]");
                            }
                        }
                        else
                        {
                            Console.WriteLine("[]");
                        }
                    }
                    break;
            }
        }

        static void LastEvenOrOddElements(int[] initialArray, int lastCount, string input)
        {
            int count = 0;

            switch (input.Split()[2])
            {
                case "odd":
                    if (lastCount > initialArray.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        if (oddElements.Length > 0)
                        {
                            if (lastCount <= oddElements.Length)
                            {
                                Console.Write("[");
                                for (int n = oddElements.Length - 1; n >= oddElements.Length - lastCount; n++)
                                {
                                    if (n == oddElements.Length - lastCount)
                                    {
                                        Console.Write($"{oddElements[n]}");
                                        continue;
                                    }
                                    Console.Write($"{oddElements[n]}, ");
                                }
                                Console.WriteLine("]");
                            }
                            else
                            {
                                Console.WriteLine($"[{string.Join(", ", oddElements)}]");
                            }
                        }
                        else
                        {
                            Console.WriteLine("[]");
                        }
                    }
                    break;
                case "even":
                    if (lastCount > initialArray.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        if (evenElements.Length > 0)
                        {
                            if (lastCount <= evenElements.Length)
                            {
                                Console.Write("[");
                                for (int n = evenElements.Length - 1; n >= evenElements.Length - lastCount; n++)
                                {
                                    if (n == evenElements.Length - lastCount)
                                    {
                                        Console.Write($"{evenElements[n]}");
                                        continue;
                                    }
                                    Console.Write($"{evenElements[n]}, ");
                                }
                                Console.WriteLine("]");
                            }
                            else
                            {
                                Console.WriteLine($"[{string.Join(", ", evenElements)}]");
                            }
                        }
                        else
                        {
                            Console.WriteLine("[]");
                        }
                    }
                    break;
            }
        }
    }
}