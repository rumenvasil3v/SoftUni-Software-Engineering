﻿using System;

namespace _14._Password_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            char c = (char)((int)'a' + l - 1);

            for (int firstSymbol = 1; firstSymbol < n; firstSymbol++)
            {
                for (int secondSymbol = 1; secondSymbol < n; secondSymbol++)
                {
                    for (char thirdSymbol = 'a'; thirdSymbol <= c; thirdSymbol++)
                    {
                        for (char fourthSymbol = 'a'; fourthSymbol <= c; fourthSymbol++)
                        {
                            for (int fifthSymbol = 1; fifthSymbol <= n; fifthSymbol++)
                            {
                                if (fifthSymbol > firstSymbol && fifthSymbol > secondSymbol)
                                {
                                    Console.Write($"{firstSymbol}{secondSymbol}{thirdSymbol}{fourthSymbol}{fifthSymbol} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
