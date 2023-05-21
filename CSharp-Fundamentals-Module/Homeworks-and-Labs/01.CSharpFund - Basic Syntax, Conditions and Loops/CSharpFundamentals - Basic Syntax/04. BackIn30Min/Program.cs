using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace _04._BackIn30Min
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Every time John tries to pay the bills he sees on the cash desk the sign: "I will be back in 30 minutes".
            //One day John was tired of waiting and decided he needed a program, which prints the time after 30 minutes, so he
            //Input:
            //Two numbers are read from the console:
            //• The first number is hours and will be between 0 and 23.
            //• The second number is minutes and will be between 0 and 59.

            //read input
            int hours = int.Parse(Console.ReadLine());// -->hours --> int
            int minutes = int.Parse(Console.ReadLine());// --> minutes --> int

            //add 30 minutes
            minutes = minutes + 30;


            //minutes > 60
            if (minutes >= 60)
            {
                hours++;
                minutes -= 60;
            }

            if (hours > 23)
            {
                hours -= 24;
            }

            Console.WriteLine($"{hours}:{minutes:d2}");
        }
    }
}
