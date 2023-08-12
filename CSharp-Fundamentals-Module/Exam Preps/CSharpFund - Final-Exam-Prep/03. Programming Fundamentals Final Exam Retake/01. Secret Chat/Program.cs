/*
heVVodar!gniV
ChangeAll:|:V:|:l
Reverse:|:!gnil
InsertSpace:|:5
Reveal

 */

using System;
using System.Linq;
using System.Text;

namespace Problem_1___Secret_Chat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string concealedMessage = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append(concealedMessage);

            string input;
            while ((input = Console.ReadLine()) != "Reveal")
            {
                string[] arguments = input
                    .Split(":|:");

                switch (arguments[0])
                {
                    case "InsertSpace":
                        int insertAtIndex = int.Parse(arguments[1]);
                        concealedMessage = concealedMessage.Insert(insertAtIndex, " ");

                        Console.WriteLine(concealedMessage);
                        break;
                    case "Reverse":
                        string reverseSubstring = arguments[1];
                        if (concealedMessage.Contains(reverseSubstring))
                        {
                            int currentSubstringIndex = concealedMessage.IndexOf(reverseSubstring);
                            concealedMessage = concealedMessage.Remove(currentSubstringIndex, reverseSubstring.Length);
                            char[] reversed = reverseSubstring.ToCharArray();
                            Array.Reverse(reversed);
                            reverseSubstring = new string(reversed);
                            concealedMessage += reverseSubstring;

                            Console.WriteLine(concealedMessage);
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;
                    case "ChangeAll":
                        string changeSubstring = arguments[1];
                        string replacement = arguments[2];

                        concealedMessage = concealedMessage.Replace(changeSubstring, replacement);

                        Console.WriteLine(concealedMessage);
                        break;
                }
            }

            Console.WriteLine($"You have a new text message: {concealedMessage}");
        }
    }
}