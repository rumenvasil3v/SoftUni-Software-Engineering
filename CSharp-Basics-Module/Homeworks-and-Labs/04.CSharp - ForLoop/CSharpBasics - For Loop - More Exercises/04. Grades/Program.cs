using System;

namespace _04._Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());

            double allGrades = 0;
            double grade2 = 0;
            double grade3 = 0;
            double grade4 = 0;
            double grade5or6 = 0;
            

            for (int i = 1; i <= students; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                allGrades += grade;

                if (grade < 3)
                {
                    grade2 ++;
                }
                else if (grade < 4)
                {
                    grade3 ++;
                }
                else if (grade < 5)
                {
                    grade4++;
                }
                else if (grade <= 6)
                {
                    grade5or6++;
                }
            }

            double average = allGrades / students;
            Console.WriteLine($"Top students: {grade5or6 / students * 100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {grade4 / students * 100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {grade3 / students * 100:f2}%");
            Console.WriteLine($"Fail: {grade2 / students * 100:f2}%");
            Console.WriteLine($"Average: {average:f2}");
        }
    }
}
