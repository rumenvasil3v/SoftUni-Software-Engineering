using System;

namespace _02._Sleepy_Tom_Cat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. We read from the console number for rest days - int.
            int restDays = int.Parse(Console.ReadLine());
            //2. We calculate one year from restDays to see how many workDays the holder has.
            int workDays = 365 - restDays;
            //3. We calculate the time that the holder have to play with his cat, accordingly to his workDays * 63 minutes a day and restDays * 127 minutes a day.
            int timeForPlay = workDays * 63 + restDays * 127;
            //4. We make variable for the norm of tha cat to play for one year.
            int norm = 30000;
            //5. We calculate the play norm for the cat, accordingly the norm, which is 30 000 and the timeForPlay, In parallel we add math operation to make negative num to positive.
            int playNorm = Math.Abs(norm - timeForPlay);
            //6. We caclulate the hours, like we divide the playNorm by 60.
            int hours = playNorm / 60;
            //7. We caclulate the minutes, like we make modular division the playNorm by 60.
            int minutes = playNorm % 60;
            
            //8. If timeForPlay is > norm, we print "Tom will run away"
            // "{hours} hours and {minutes} minutes more for play"
            if (timeForPlay > norm)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
            //9. If the norm is > timeForPlay, we print "Tom sleeps well"
            //  "{hours} hours and {minutes} minutes less for play"
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
        }
    }
}
