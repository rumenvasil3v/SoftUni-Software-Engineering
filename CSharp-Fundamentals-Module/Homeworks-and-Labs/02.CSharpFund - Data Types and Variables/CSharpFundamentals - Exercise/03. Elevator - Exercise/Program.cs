using System;

namespace _03._Elevator___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacityOfPeople = int.Parse(Console.ReadLine());

            int courses = (numberOfPeople / capacityOfPeople);
            if (numberOfPeople % capacityOfPeople != 0)
            {
                courses++;
            }

            Console.WriteLine(courses);
        }
    }
}
