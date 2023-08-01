/*
abcd efgh ijkl
divide 0 3
3:1
 */

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace _08._Anonymous_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> randomText = Console
                .ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input;
            while ((input = Console.ReadLine()) != "3:1")
            {
                string[] arguments = input.Split();

                switch (arguments[0])
                {
                    case "merge":
                        string concat = string.Empty;
                        int startIndex = int.Parse(arguments[1]);
                        int endIndex = int.Parse(arguments[2]);
                        if (startIndex < 0 || startIndex > randomText.Count - 1)
                        {
                            startIndex = 0;
                        }

                        if (endIndex > randomText.Count - 1)
                        {
                            endIndex = randomText.Count - 1;
                        }

                        for (int n = startIndex; n <= endIndex; n++)
                        {
                            concat += randomText[n];
                        }

                        randomText.RemoveRange(startIndex, endIndex - startIndex + 1);
                        randomText.Insert(startIndex, concat);
                        break;
                    case "divide":
                        int index = int.Parse(arguments[1]);
                        int partitions = int.Parse(arguments[2]);
                        string substring = randomText[index];
                        string partition = string.Empty;

                        randomText.RemoveAt(index);
                        if (substring.Length % partitions == 0)
                        {
                            
                            for (int n = 0; n < substring.Length; n += substring.Length / partitions)
                            {
                                partition = substring.Substring(n, substring.Length / partitions);
                                randomText.Insert(index, partition);

                                index++;
                            }
                        }
                        else
                        {
                            int count = 0;
                            for (int n = 0; n < substring.Length; n += substring.Length / partitions)
                            {
                                count++;

                                if (count == partitions)
                                {
                                    partition = substring.Substring(n, substring.Length - n);
                                    randomText.Insert(index, partition);
                                    break;
                                }

                                partition = substring.Substring(n, substring.Length / partitions);
                                randomText.Insert(index, partition);

                                index++;
                            }
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", randomText));
        }

        //public static IEnumerable<string> Partition(this string input, int partitionSize)
        //{
        //    for (int i = 0; i < input.Length; i += partitionSize)
        //    {
        //        yield return input.Substring(i, partitionSize);
        //    }
        //}
    }
}