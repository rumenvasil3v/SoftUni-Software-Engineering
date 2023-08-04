/*
Data Types, Objects, Lists
Add:Databases
Exercise:Databases
Exercise:Objects
Exercise:Data Types
Insert:Arrays:0
Exercise:Arrays
Remove:Arrays
Swap:Databases:Data Types
Exercise:Databases
Remove:Lists
course start

Arrays, Lists, Methods
Swap:Arrays:Methods
Exercise:Databases
Swap:Lists:Databases
Insert:Arrays:0
course start
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> fundamentalsCourseLessons = Console
                .ReadLine()
                .Split(", ")
                .ToList();

            string input;
            while ((input = Console.ReadLine()) != "course start")
            {
                string[] commands = input.Split(':');

                switch (commands[0])
                {
                    case "Add":
                        string lessonToAdd = commands[1];

                        if (!fundamentalsCourseLessons.Contains(lessonToAdd))
                        {
                            fundamentalsCourseLessons.Add(lessonToAdd);
                        }
                        break;
                    case "Insert":
                        string lessonToInsert = commands[1];
                        int indexToInsert = int.Parse(commands[2]);

                        if (!fundamentalsCourseLessons.Contains(lessonToInsert))
                        {
                            fundamentalsCourseLessons.Insert(indexToInsert, lessonToInsert);
                        }
                        break;
                    case "Remove":
                        string lessonToRemove = commands[1];

                        if (fundamentalsCourseLessons.Contains(lessonToRemove))
                        {
                            fundamentalsCourseLessons.Remove(lessonToRemove);

                            if (fundamentalsCourseLessons.Contains($"{lessonToRemove}-Exercise"))
                            {
                                int indexToRemove = fundamentalsCourseLessons.IndexOf($"{lessonToRemove}-Exercise");
                                fundamentalsCourseLessons.RemoveAt(indexToRemove);
                            }
                        }
                        break;
                    case "Swap":
                        string currentLesson = commands[1];
                        string lessonToSwap = commands[2];

                        if (fundamentalsCourseLessons.Contains(currentLesson)
                            && fundamentalsCourseLessons.Contains(lessonToSwap))
                        {
                            int currentLessonIndex = fundamentalsCourseLessons.IndexOf(currentLesson);
                            int lessonToSwapIndex = fundamentalsCourseLessons.IndexOf(lessonToSwap);

                            fundamentalsCourseLessons[currentLessonIndex] = lessonToSwap;
                            fundamentalsCourseLessons[lessonToSwapIndex] = currentLesson;

                            if (fundamentalsCourseLessons.Contains($"{currentLesson}-Exercise"))
                            {
                                fundamentalsCourseLessons.Remove($"{currentLesson}-Exercise");
                                fundamentalsCourseLessons.Insert(lessonToSwapIndex + 1, $"{currentLesson}-Exercise");
                            }

                            if (fundamentalsCourseLessons.Contains($"{lessonToSwap}-Exercise"))
                            {
                                fundamentalsCourseLessons.Remove($"{lessonToSwap}-Exercise");
                                fundamentalsCourseLessons.Insert(currentLessonIndex + 1, $"{lessonToSwap}-Exercise");
                            }
                        }
                        break;
                    case "Exercise":
                        string exerciseLesson = commands[1];

                        if (fundamentalsCourseLessons.Contains(exerciseLesson)
                            && !fundamentalsCourseLessons.Contains($"{exerciseLesson}-Exercise"))
                        {
                            int currentLessonIndex = fundamentalsCourseLessons.IndexOf(exerciseLesson);

                            fundamentalsCourseLessons.Insert(currentLessonIndex + 1, $"{exerciseLesson}-Exercise");
                        }
                        else if (!fundamentalsCourseLessons.Contains(exerciseLesson)
                            && !fundamentalsCourseLessons.Contains($"{exerciseLesson}-Exercise"))
                        {
                            fundamentalsCourseLessons.Add(exerciseLesson);
                            fundamentalsCourseLessons.Add($"{exerciseLesson}-Exercise");
                        }
                        break;
                }
            }

            for (int n = 0; n < fundamentalsCourseLessons.Count; n++)
            {
                Console.WriteLine($"{n + 1}.{fundamentalsCourseLessons[n]}");
            }
        }
    }
}