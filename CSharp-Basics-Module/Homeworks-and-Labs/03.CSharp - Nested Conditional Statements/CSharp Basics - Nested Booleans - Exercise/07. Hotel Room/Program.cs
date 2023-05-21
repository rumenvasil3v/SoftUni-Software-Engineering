using System;

namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int numberNights = int.Parse(Console.ReadLine());

            double studio = 0;
            double apartment = 0;

            if (month == "May" || month == "October")
            {
                if (numberNights > 14)
                {
                    studio = numberNights * 50;
                    studio = studio - studio * 0.3;

                    apartment = numberNights * 65;
                    apartment -= apartment * 0.1;
                }
                else if (numberNights > 7) 
                {
                    studio = numberNights * 50;
                    studio = studio - studio * 0.05;

                    apartment = numberNights * 65;
                }
                else
                {
                    studio = numberNights * 50;
                    apartment= numberNights * 65;
                }
            }
            else if (month == "June" || month == "September")
            {
                if (numberNights > 14)
                {
                    studio = numberNights * 75.20;
                    studio = studio - studio * 0.2;

                    apartment = numberNights * 68.70;
                    apartment -= apartment * 0.1;
                }
                else
                {
                    studio = numberNights * 75.20;
                    apartment = numberNights * 68.70;
                }
            }
            else
            {
                if (numberNights > 14)
                {
                    apartment = numberNights * 77;
                    apartment -= apartment * 0.1;

                    studio = numberNights * 76;
                }
                else
                {
                    studio = numberNights * 76;
                    apartment = numberNights * 77;
                }
            }
            Console.WriteLine($"Apartment: {apartment:f2} lv.");
            Console.WriteLine($"Studio: {studio:f2} lv.");
        }
    }
}
