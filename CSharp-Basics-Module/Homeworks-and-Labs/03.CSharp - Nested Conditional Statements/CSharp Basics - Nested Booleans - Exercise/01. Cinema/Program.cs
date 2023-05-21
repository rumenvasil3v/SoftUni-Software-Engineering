using System;

namespace _01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Variables for type of the screen, number of rows and columns at the hall
            string screenType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            //2. Make constant variable which value is 0
            double income = rows * columns;
            //3. Check whether screen type is "Premiere" = 12.00, "Normal"= 7.50 or "Discount" = 5.00
            switch (screenType)
            {
                case "Premiere":
                    income = income * 12.00;
                    break;
                case "Normal":
                    income = income * 7.50;
                    break;
                case "Discount":
                    income = income * 5.00;
                    break;
            }
            //4. Output the income price from tickets.
            Console.WriteLine("{0:F2} leva", income);
        }
    }
}
