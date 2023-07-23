using System;

namespace _01._Activation_Keys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rawActivationKey = Console.ReadLine();

            string input;
            while ((input = Console.ReadLine()) != "Generate")
            {
                string[] instructions = input
                    .Split(">>>");

                switch (instructions[0])
                {
                    case "Contains":
                        string substring = instructions[1];

                        if (rawActivationKey.Contains(substring))
                        {
                            Console.WriteLine($"{rawActivationKey} contains {substring}");
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }
                        break;
                    case "Flip":
                        string substringCase = instructions[1];
                        int startIndex = int.Parse(instructions[2]);
                        int endIndex = int.Parse(instructions[3]);

                        string extractSubstring = rawActivationKey.Substring(startIndex, endIndex - startIndex);
                        if (substringCase == "Upper")
                        {
                            extractSubstring = extractSubstring.ToUpper();
                            rawActivationKey = rawActivationKey.Remove(startIndex, endIndex - startIndex);
                            rawActivationKey = rawActivationKey.Insert(startIndex, extractSubstring);
                            Console.WriteLine(rawActivationKey);
                        }
                        else if (substringCase == "Lower")
                        {
                            extractSubstring = extractSubstring.ToLower();
                            rawActivationKey = rawActivationKey.Remove(startIndex, endIndex - startIndex);
                            rawActivationKey = rawActivationKey.Insert(startIndex, extractSubstring);
                            Console.WriteLine(rawActivationKey);
                        }
                        break;
                    case "Slice":
                        int sliceStartIndex = int.Parse(instructions[1]);
                        int sliceEndIndex = int.Parse(instructions[2]);

                        rawActivationKey = rawActivationKey.Remove(sliceStartIndex, sliceEndIndex - sliceStartIndex);
                        Console.WriteLine(rawActivationKey);
                        break;
                }
            }

            Console.WriteLine($"Your activation key is: {rawActivationKey}");
        }
    }
}
