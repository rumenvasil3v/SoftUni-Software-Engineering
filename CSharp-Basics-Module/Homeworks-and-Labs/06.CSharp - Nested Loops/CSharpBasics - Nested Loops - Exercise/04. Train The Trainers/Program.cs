using System;

namespace _04._Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Read num of judgers
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            // Make variables for:
            // => name of presentaion
            string presentationName;
            // => count of presentations
            int countPresentations = 0;
            // => sum of all grades
            double grade = 0;
            double studentGrade = 0; // sum of all average grades


            //2. Create loop, which will execute, until we receive "Finish"
            while (input != "Finish")
            {
                //like name of presentation assign value of entrance
                presentationName = input;
                grade = 0;
                // create for loop, which will execute from fisrt judger to last judger
                for (int i = 1; i <= n; i++)
                {
                    // => read grade for current presentation and add it to sum of the other presentations
                    grade += double.Parse(Console.ReadLine());
                }

                grade /= n;
                Console.WriteLine($"{presentationName} - {grade:f2}.");

                studentGrade += grade;
                countPresentations++;
                // => read new entrance from the console
                input = Console.ReadLine();
            }

            //3. Print average grade from all presentations
            Console.WriteLine($"Student's final assessment is {studentGrade / countPresentations:f2}.");
        }
    }
}
