using System;

namespace _06._Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countStandard = 0;
            int countStudents = 0;
            int countKids = 0;
            int totalCount = 0;
            int allTickets = 0;
            int places = 0;

            int allStudents = 0;
            int allKids = 0;
            int allStandards = 0;

            string input;

            while ((input = Console.ReadLine()) != "Finish")
            {
                int freePlaces = int.Parse(Console.ReadLine());

                places = freePlaces;

                string type;
                while (freePlaces > 0 && (type =Console.ReadLine()) != "End")
                {
                    if (type == "student")
                    {
                        countStudents++;
                        freePlaces--;
                        allTickets++;
                        allStudents++;
                    }
                    else if (type == "standard")
                    {
                        countStandard++;
                        freePlaces--;
                        allTickets++;
                        allStandards++;
                    }
                    else if (type == "kid")
                    {
                        countKids++;
                        freePlaces--;
                        allTickets++;
                        allKids++;
                    }
                    totalCount = countKids + countStandard + countStudents;
                    
                    
                }
                Console.WriteLine($"{input} - {totalCount / (double)places * 100:F2}% full.");
                countStudents = 0;
                countKids = 0;
                countStandard = 0;
                totalCount= 0;
            }

            Console.WriteLine($"Total tickets: {allTickets}");
            Console.WriteLine($"{allStudents / (double)allTickets * 100:f2}% student tickets.");
            Console.WriteLine($"{allStandards / (double)allTickets * 100:f2}% standard tickets.");
            Console.WriteLine($"{allKids / (double)allTickets * 100:f2}% kids tickets.");
        }
    }
}
