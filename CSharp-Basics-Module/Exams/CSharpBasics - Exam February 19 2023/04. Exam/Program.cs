using System;

namespace _04._Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentsExam = int.Parse(Console.ReadLine());

            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            double marksSum = 0;

            for (int i = 1; i <= studentsExam; i++)
            {
                double markExam = double.Parse(Console.ReadLine());
                marksSum += markExam;

                if (markExam >= 5.00 && markExam <= 6)
                {
                    p1++;
                }
                else if (markExam >= 4.00)
                {
                    p2++;
                }
                else if (markExam >= 3)
                {
                    p3++;
                }
                else
                {
                    p4++;
                }
            }

            Console.WriteLine($"Top students: {(double)p1 / studentsExam * 100:F2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {(double)p2 / studentsExam * 100:F2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {(double)p3 / studentsExam * 100:F2}%");
            Console.WriteLine($"Fail: {(double)p4 / studentsExam * 100:F2}%");
            Console.WriteLine($"Average: {marksSum / studentsExam:F2}");
        }
    }
}
