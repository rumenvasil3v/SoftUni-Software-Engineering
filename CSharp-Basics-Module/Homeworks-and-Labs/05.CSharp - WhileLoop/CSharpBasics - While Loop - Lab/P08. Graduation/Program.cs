using System;

namespace P08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int grade = 1;
            int classRepetition = 0;
            double marksSum = 0;
            while (grade <= 12)
            {
                double currentGradeMark = double.Parse(Console.ReadLine());

                if (currentGradeMark < 4)
                {
                    classRepetition++;

                    if (classRepetition > 1)
                    {
                        break;
                    }

                    continue;
                }

                marksSum += currentGradeMark;
                grade++;
            }

            // Two ways to come here: natural(end condition) and forced(break)
            if (classRepetition > 1)
            {
                // Excluded
                Console.WriteLine($"{name} has been excluded at {grade} grade");
            }
            else
            {
                // Graduated
                double averageMark = marksSum / 12;
                Console.WriteLine($"{name} graduated. Average grade: {averageMark:f2}");
            }
        }
    }
}
