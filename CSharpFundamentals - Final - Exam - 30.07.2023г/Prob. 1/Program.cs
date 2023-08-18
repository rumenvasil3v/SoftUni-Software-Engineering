/*
//Th1s 1s my str1ng!//
Change 1 i
Includes string
End my
Uppercase
FindIndex I
Cut 5 5
Done

*S0ftUni is the B3St Plac3**
Change 2 o
Includes best
End is
Uppercase
FindIndex P
Cut 3 7
Done 
 */

namespace Prob._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string input;
            while ((input = Console.ReadLine()) != "Done")
            {
                string[] commands = input
                    .Split();

                switch(commands[0])
                {
                    case "Change":
                        char replaceChar = char.Parse(commands[1]);
                        char replacement = char.Parse(commands[2]);

                        text = text.Replace(replaceChar, replacement);

                        Console.WriteLine(text);
                        break;
                    case "Includes":
                        string substring = commands[1];

                        if (text.Contains(substring))
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                        break;
                    case "End":
                        string endSubstring = commands[1];

                        if (text.EndsWith(endSubstring))
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                        break;
                    case "Uppercase":
                        text = text.ToUpper();

                        Console.WriteLine(text);
                        break;
                    case "FindIndex":
                        char charToFind = char.Parse(commands[1]);

                        int indexOfString = text.IndexOf(charToFind);

                        Console.WriteLine(indexOfString);
                        break;
                    case "Cut":
                        int startIndexToCut = int.Parse(commands[1]);
                        int count = int.Parse(commands[2]);

                        string substringToCut = text.Substring(startIndexToCut, count);

                        Console.WriteLine(substringToCut);
                        break;
                }
            }
        }
    }
}