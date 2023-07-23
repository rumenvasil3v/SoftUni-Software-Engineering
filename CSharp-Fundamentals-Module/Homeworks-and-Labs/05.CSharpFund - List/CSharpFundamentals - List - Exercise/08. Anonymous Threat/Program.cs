using System;
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

            string concat = string.Empty;
            string input = Console.ReadLine();
            while (input != "3:1")
            {
                string[] arguments = input.Split();

                switch (arguments[0])
                {
                    case "merge":
                        int startIndex = int.Parse(arguments[1]);
                        int endIndex = int.Parse(arguments[2]);
                        randomText = MergeFromStartIndexToEndIndex(randomText, startIndex, endIndex, concat);
                        break;
                    case "divide":
                        int index = int.Parse(arguments[1]);
                        int partitions = int.Parse(arguments[2]);
                        break;
                }

                input = Console.ReadLine();
            }

        }

        static List<string> MergeFromStartIndexToEndIndex(List<string> merged, int startIndex, int endIndex, string concat)
        {
            for (int i = startIndex; i <= endIndex; i++)
            {
                if (IsItOutsideTheArray(startIndex, endIndex, merged))
                {
                    for (int j = 0; j < merged.Count; j++)
                    {
                        //merged[i] 
                    }
                }

                merged.Insert(0, merged[i]);
            }

            return merged;
        }

        static bool IsItOutsideTheArray(int startIndex, int endIndex, List<string> merged)
        {
            if (startIndex < 0)
            {
                return true;
            }

            if (endIndex >= merged.Count)
            {
                return true;
            }

            return false;
        }
    }
}
