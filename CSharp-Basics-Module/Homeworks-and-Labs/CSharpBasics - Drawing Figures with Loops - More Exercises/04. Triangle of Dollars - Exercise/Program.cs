﻿using Microsoft.VisualBasic;
using System;

namespace _04._Triangle_of_Dollars___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int rows = 1; rows <= n; rows++)
            {
                for (int columns = 1; columns <= rows; columns++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine();
            }
        }
    }
}
