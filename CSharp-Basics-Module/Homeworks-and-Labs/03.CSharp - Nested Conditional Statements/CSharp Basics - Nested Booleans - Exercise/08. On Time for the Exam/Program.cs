using System;

namespace _08._On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. We read from the console hour and minutes for the exam
            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            // -> hour and minutes to minutes
            examMin = examMin + examHour * 60;
            //2. We read from the console hour and minutes arrival
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMin = int.Parse(Console.ReadLine());
            // -> hour and minutes to minutes
            arrivalMin = arrivalMin + arrivalHour * 60;
            //3. Calculate between minutes for the exam and mminutes for arrival
            int difference = examMin - arrivalMin;
            //4. Depending on the difference between minutes for the exam and minutes for arrival
            if (difference < 0)
            {
                Console.WriteLine("Late");
                if (difference > -60)
                {
                    Console.WriteLine($"{Math.Abs(difference)} minutes after the start");
                }
                else
                {
                    Console.WriteLine($"{Math.Abs(difference/60)}:{Math.Abs(difference%60):D2} hours after the start");
                }
            }
            else if (difference >= 0 && difference <= 30)
            {
                Console.WriteLine("On time");
                if (difference > 0)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
            }
            else
            {
                if (difference < 60)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else
                {
                    Console.WriteLine($"early {difference / 60}:{difference % 60:D2} hours before the start");
                }
            }

        }
    }
}
