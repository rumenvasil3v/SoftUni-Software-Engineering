using System;

namespace _03._Stream_Of_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            bool isValid = char.TryParse(input, out char something);

            string word = string.Empty;
            string words = string.Empty;

            bool meetedC = false;
            bool meetedO = false;
            bool meetedN = false;

            while (input != "End")
            {
                if (isValid)
                {
                    if ( something >= 65 && something <= 90 || something >= 97 && something <= 122)
                    {
                        if (meetedC && something == 'c')
                        {
                            word += something;
                            input = Console.ReadLine();
                            isValid = char.TryParse(input, out something);
                            continue;
                        }
                        else if (meetedN && something == 'n')
                        {
                            word += something;
                            input = Console.ReadLine();
                            isValid = char.TryParse(input, out something);
                            continue;
                        }
                        else if (meetedO && something == 'o')
                        {
                            word += something;
                            input = Console.ReadLine();
                            isValid = char.TryParse(input, out something);
                            continue;
                        }
                        else if (something == 'c' && !meetedC)
                        {
                            meetedC = true;
                            input = Console.ReadLine();
                            isValid = char.TryParse(input, out something);
                            continue;
                        }
                        else if (something == 'o' && !meetedO)
                        {
                            meetedO = true;
                            input = Console.ReadLine();
                            isValid = char.TryParse(input, out something);
                            continue;
                        }
                        else if (something == 'n' && !meetedN)
                        {
                            meetedN = true;
                            input = Console.ReadLine();
                            isValid = char.TryParse(input, out something);
                            continue;
                        }


                        if (meetedN && meetedC && meetedO)
                        {
                            words += word + " ";

                            word = string.Empty;
                            word += something;

                            meetedN = false;
                            meetedC = false;
                            meetedO = false;

                            input = Console.ReadLine();
                            isValid = char.TryParse(input, out something);

                            continue;
                        }

                        word += something;

                        input = Console.ReadLine();
                        isValid = char.TryParse(input, out something);
                    }
                    else
                    {
                        input = Console.ReadLine();
                        isValid = char.TryParse(input, out something);
                    }
                }
                else
                {
                    input = Console.ReadLine();
                    isValid = char.TryParse(input, out something);
                }
            }

            if (meetedN && meetedC && meetedO)
            {
                words += word + " ";
            }

            Console.WriteLine(words);
        }
    }
}
