using System;
/*
 30
Students
Sunday

 40
Regular
Saturday
 */
namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();

            double priceForOnePerson = 0;
            double totalPrice = 0;

            if (typeOfGroup == "Students")
            {
                if (dayOfTheWeek == "Friday")
                {
                    priceForOnePerson = 8.45;
                }
                else if (dayOfTheWeek == "Saturday")
                {
                    priceForOnePerson = 9.80;
                }
                else if (dayOfTheWeek == "Sunday")
                {
                    priceForOnePerson = 10.46;
                }

                totalPrice = countOfPeople * priceForOnePerson;

                if (countOfPeople >= 30)
                {
                    totalPrice = totalPrice * 0.85;
                }
            }
            else if (typeOfGroup == "Business")
            {
                if (dayOfTheWeek == "Friday")
                {
                    priceForOnePerson = 10.90;
                }
                else if (dayOfTheWeek == "Saturday")
                {
                    priceForOnePerson = 15.60;
                }
                else if (dayOfTheWeek == "Sunday")
                {
                    priceForOnePerson = 16;
                }

                if (countOfPeople >= 100)
                {
                    countOfPeople = countOfPeople - 10;
                }

                totalPrice = countOfPeople * priceForOnePerson;
            }
            else
            {
                if (dayOfTheWeek == "Friday")
                {
                    priceForOnePerson = 15;
                }
                else if (dayOfTheWeek == "Saturday")
                {
                    priceForOnePerson = 20;
                }
                else if (dayOfTheWeek == "Sunday")
                {
                    priceForOnePerson = 22.50;
                }

                if (countOfPeople >= 10 && countOfPeople <= 20)
                {
                    totalPrice = totalPrice * 0.95;
                }

                totalPrice = countOfPeople * priceForOnePerson;
            }

            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
