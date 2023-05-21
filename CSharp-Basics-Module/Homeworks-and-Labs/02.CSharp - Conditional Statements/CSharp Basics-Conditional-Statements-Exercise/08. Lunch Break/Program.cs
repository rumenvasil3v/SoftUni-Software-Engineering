using System;

namespace _08._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. We read from the Console "Name of serial"-(string)
            string serial = Console.ReadLine();
            //2. We read from the console "Duration for one episode"-(int)
            int oneEpisode = int.Parse(Console.ReadLine());
            //3. We read from the console "Duration for the rest time"-(int)
            int restTime = int.Parse(Console.ReadLine());
            
            //4. We make variable for needed time for lunch, which is 1/8 from the rest time.
            double timeForLunch = restTime * 0.125;
           
            //5. We make varialble for needed time for recreation, which is 1/4 from the rest time.
            double timeForRecreation = restTime * 0.25;
            //6. We calculate the left time, when we subtract (restTime) from (timeForLunch) and (timeForRecreation)
            double timeLeft = restTime - (timeForLunch + timeForRecreation);
            //7. On the Console we must write, if the time is enough.
            // -> You have enough time to watch {serial} and left with {left time} minutes free time.
            //   If the time isn't enough.
            // -> You don't have enough time to watch {serial}, you need {needed time} more minutes.
             if (timeLeft >= oneEpisode)
            {
                Console.WriteLine($"You have enough time to watch {serial} and left with {Math.Ceiling(timeLeft - oneEpisode)} minutes free time.");
            }
             else
            {
                Console.WriteLine($"You don't have enough time to watch {serial}, you need {Math.Ceiling(oneEpisode - timeLeft)} more minutes.");
            }
            //8. You need to Round the Time with the nearest number up.
        }
    }
}
