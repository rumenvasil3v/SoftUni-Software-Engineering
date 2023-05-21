using System;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Read from the console number of unsatisfying mark, which he can gets
            int failedTimes = int.Parse(Console.ReadLine());

            //2. Make variables for:
            // sum of all marks
            int evoluationSum = 0;
            // count of all marks
            int evoluationCount = 0;
            // count of unpleased marks
            int failedCount = 0;
            // name of last exercise
            string lastExercise = string.Empty;


            string input = Console.ReadLine();
            int evoluation;
            //3. Create while loop, which execute, until he gets message "Enough"
            while (input != "Enough")
            {
                // => if input is != from "Enough" => he is name of the last task at the moment.
                lastExercise = input;
                // => read mark for define task
                evoluation = int.Parse(Console.ReadLine());
                // => add the mark to the sum of all marks at the moment
                evoluationSum += evoluation;
                // => increase count of all marks with 1
                evoluationCount++;
                // => check whether this mark is satisfying ?
                if (evoluation <= 4)
                {
                    // increase count of unsatisfying with 1
                    failedCount++;
                    // => check whether he has reached count of unsatisfying marks, fоr to interrupt
                    if (failedCount == failedTimes)
                    {
                        // => if it is:
                        // print something ->
                        Console.WriteLine($"You need a break, {failedCount} poor grades.");
                        // => stop while loop
                        break;
                    }
                }
                input= Console.ReadLine();
            }

            //4. Check whether last input == "Enough"
            if (input == "Enough")
            {
                Console.WriteLine($"Average score: {(double)evoluationSum / evoluationCount:f2}");
                Console.WriteLine($"Number of problems: {evoluationCount}");
                Console.WriteLine($"Last problem: {lastExercise}");
            }
        }
    }
}
