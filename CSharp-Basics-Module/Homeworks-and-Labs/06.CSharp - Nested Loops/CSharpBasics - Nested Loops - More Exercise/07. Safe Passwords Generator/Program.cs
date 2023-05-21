using System;

namespace _07._Safe_Passwords_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int maxPasswords = int.Parse(Console.ReadLine());
            bool isValid = false;

            int combinations = 0;

            for (char A = '#'; A <= '7'; A++)
            {
                for (char B = '@'; B <= '`'; B++)
                {
                    for (int x = 1; x <= a; x++)
                    {
                        for (int y = 1; y <= b; y++)
                        {
                            if (A > '7')
                            {
                                A = '#';
                            }

                            if (B > '`')
                            {
                                B = '@';
                            }


                            Console.Write($"{A}{B}{x}{y}{B}{A}|");
                            A++;
                            B++;
                            combinations++;
                            if (x == a && y == b)
                            {
                                isValid = true;
                                break;
                            }
                            if (combinations == maxPasswords)
                            {
                                isValid = true;
                                break;
                            }
                        }
                        if (isValid)
                        {
                            break;
                        }
                    }
                    if (isValid)
                    {
                        break;
                    }
                }
                if (isValid)
                {
                    break;
                }
            }
        }
    }
}
