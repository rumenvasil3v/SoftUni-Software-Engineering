using System;

namespace P01._Sum_Seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Четем от конзолата времето на първия, втория и третия състезател.
            int firstCompetitor = int.Parse(Console.ReadLine());
            int secondCompetitor = int.Parse(Console.ReadLine());
            int thirdCompetitor = int.Parse(Console.ReadLine());

            //2. Намираме общото време им време в секунди.
            int totalTime = firstCompetitor + secondCompetitor + thirdCompetitor;
            //3. Намираме колко минути и колко секунди им е общото време. 
            int minutes = totalTime / 60;
            int seconds = totalTime % 60;
            //4.Извеждаме резултата на конзолата
            // => проверяваме дали секундите са < 10.
            Console.WriteLine($"{minutes}:{seconds:d2}");
        }
    }
}
