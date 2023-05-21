using System;

namespace _06._World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Четем вход от конзолата за рекорд в секунди.
            double worldRecord = double.Parse(Console.ReadLine());
            //2. Четем вход от конзолата за разстояние в метри.
            double distance = double.Parse(Console.ReadLine());
            //3. Четем вход от конзолата за времето в секунди, за което плува разстояние от 1 метър.
            double timeSeconds = double.Parse(Console.ReadLine());
            //4. Умножаваме дистанцията, която Иван трябва да измине, за времето секунди, които плува за 1 метър.
            double timeRecord = distance * timeSeconds;
            //5. Съпротивлението на водата го забавя на всеки 15 м. с 12.5 сек, и затова делим дистанцията / 15 и * по 12.5.
            double resistanceWater =(int)(distance / 15) * 12.5;
            //6. Събираме времето, за което е преплувал прочетените от конзолата секунди и метри, с съпротивлението на водата, което го забавя и получаваме неговото време. 
            timeRecord = timeRecord + resistanceWater;
            //7. Ако неговото време е по - малко от рекордното, значи е подобрил рекорда.
            // отпечатваме {timeRecord}.
            if (timeRecord < worldRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {timeRecord:f2} seconds.");
            }
            //8. Ако не е подобрил рекорда(неговото време е > от световния рекорд)
            // изчисляваме разликата от неговото време и световния рекорд за да видим колко сек. е по-бавен.
            //отпечатваме {timeRecord}.
            else if (timeRecord >= worldRecord)
            {
                timeRecord = timeRecord - worldRecord;
                Console.WriteLine($"No, he failed! He was {timeRecord:f2} seconds slower.");
            }
            //9. Изход от програмата.
        }
    }
}
