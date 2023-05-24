using System;
/*
 17
3

4
5

10
5

 */
namespace _03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INPUT 
            sbyte numberOfPeople = sbyte.Parse(Console.ReadLine());
            sbyte capacityOfPeople = sbyte.Parse(Console.ReadLine());
            
            //IMPLEMENTATION
            sbyte courses = 0;
            while (numberOfPeople > 0)
            {
                numberOfPeople -= capacityOfPeople;
      
                if (numberOfPeople == 0)
                {
                    courses++;
                    break;
                }
                courses++;
            }

            //OUTPUT
            Console.WriteLine(courses);
        }
    }
}
