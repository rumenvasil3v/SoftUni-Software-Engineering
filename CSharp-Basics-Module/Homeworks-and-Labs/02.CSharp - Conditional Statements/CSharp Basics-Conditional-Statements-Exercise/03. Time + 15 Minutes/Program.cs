using System;

namespace _03._Time___15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes = minutes + hour * 60;
            minutes = minutes + 15;
            hour = minutes / 60;
            minutes = minutes % 60;




            if (hour == 24)
            {
                hour = 0;
            }


            Console.WriteLine($"{hour}:{minutes:D2}");
            
        }
    }
}

