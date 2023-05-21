using System;
using System.Text.RegularExpressions;

namespace _07._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine()); // read from console groups 
           
            double peopleSum = 0; // make variable for the total sum of the people in the groups
            double p1 = 0; 
            double p2 = 0;     // make variables ->
            double p3 = 0;     // for the percent of the groups 
            double p4 = 0;     // that will climb certain peaks
            double p5 = 0; 

            for (int i = 1; i <= groups; i++)
            {
                int people = int.Parse(Console.ReadLine());
                peopleSum = people + peopleSum;

                if (people <= 5)
                {
                    p1 = people + p1;
                }
                else if (people > 5 && people <= 12)
                {
                    p2 = people + p2;
                }
                else if (people > 12 && people <= 25)
                {
                    p3 = people + p3;
                }
                else if (people > 25 && people <= 40)
                {
                    p4 = people + p4;
                }
                else
                {
                    p5 = people + p5;
                }
            }
                                                             
            Console.WriteLine($"{p1 / peopleSum * 100:f2}%");
            Console.WriteLine($"{p2 / peopleSum * 100:f2}%");
            Console.WriteLine($"{p3 / peopleSum * 100:f2}%");
            Console.WriteLine($"{p4 / peopleSum * 100:f2}%");
            Console.WriteLine($"{p5 / peopleSum * 100:f2}%");
        }
    }
}
