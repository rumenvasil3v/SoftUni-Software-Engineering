using System;

namespace Problem_1___Bonus_Scoring_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte numberOfStudents = byte.Parse(Console.ReadLine());
            byte totalNumberOfLectures = byte.Parse(Console.ReadLine());
            byte additionalBonus = byte.Parse(Console.ReadLine());

            float maxBonus = 0;
            int studentAttendances = 0;

            for (int i = 1; i <= numberOfStudents; i++)
            {
                int countOfAttendancesForEachStudent = int.Parse(Console.ReadLine());

                float totalBonus = (float)(countOfAttendancesForEachStudent) / (float)(totalNumberOfLectures) * (5 + additionalBonus);
                if (totalBonus > maxBonus)
                {
                    maxBonus = totalBonus;
                    studentAttendances = countOfAttendancesForEachStudent;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {studentAttendances} lectures.");
        }
    }
}