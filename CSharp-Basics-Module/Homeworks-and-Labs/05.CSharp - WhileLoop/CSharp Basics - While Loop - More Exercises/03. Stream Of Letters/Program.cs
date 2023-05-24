using System;
using System.Threading;
using System.Xml;

namespace _03._Stream_Of_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            string word = string.Empty;

            int meetedC = 0;
            int meetedO = 0;
            int meetedN = 0;

            while (input != "End")
            {
                if (meetedC == 1 && input == "c")
                {
                    word += input;
                    meetedC++;
                    input = Console.ReadLine();
                    continue;
                }
                else if (meetedN == 1 && input == "n")
                {
                    word += input;
                    meetedN++;
                    input = Console.ReadLine();
                    continue;
                }
                else if (meetedO == 1 && input == "o")
                {
                    word += input;
                    meetedO++;
                    input = Console.ReadLine();
                    continue;
                }
                else if (input == "c")
                {
                    meetedC++;
                    input = Console.ReadLine();
                    continue;
                }
                else if (input == "o")
                {
                    meetedO++;
                    input = Console.ReadLine();
                    continue;
                }
                else if (input == "n")
                {
                    meetedN++;
                    input = Console.ReadLine();
                    continue;
                }

                
                if (meetedC > 0 && meetedN > 0 && meetedO > 0)
                {
                    Console.WriteLine($"{word} ");
                    word = string.Empty;
                    input = Console.ReadLine();
                    meetedO = 0;
                    meetedC = 0;
                    meetedN = 0;
                    continue;
                }

                word += input;

                input = Console.ReadLine();
            }

            Console.WriteLine($"{word}");
        }
    }
}
