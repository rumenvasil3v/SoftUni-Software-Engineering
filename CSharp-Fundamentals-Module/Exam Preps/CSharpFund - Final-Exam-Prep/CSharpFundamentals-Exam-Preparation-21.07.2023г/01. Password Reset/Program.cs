/*
up8rgoyg3r1atmlmpiunagt!-irs7!1fgulnnnqy
Cut 18 2
Substitute ! ***
Substitute ? .!.
Done
 */

using System;

namespace _01._Password_Reset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string randomString = Console.ReadLine();

            string input;
            while ((input = Console.ReadLine()) != "Done")
            {
                string[] commands = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                switch (commands[0])
                {
                    case "TakeOdd":
                        string newPassword = string.Empty;
                        for (int i = 0; i < randomString.Length; i++)
                        {
                            if (i % 2 == 1)
                            {
                                newPassword += randomString[i];
                            }
                        }

                        randomString = newPassword;

                        Console.WriteLine(randomString);
                        break;
                    case "Cut":
                        int startIndex = int.Parse(commands[1]);
                        int length = int.Parse(commands[2]);

                        randomString = randomString.Remove(startIndex, length);

                        Console.WriteLine(randomString);
                        break;
                    case "Substitute":
                        string substring = commands[1];
                        string substitute = commands[2];

                        if (randomString.Contains(substring))
                        {
                            randomString = randomString.Replace(substring, substitute);

                            Console.WriteLine(randomString);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }
                        break;
                }
            }

            Console.WriteLine($"Your password is: {randomString}");
        }
    }
}
