using System;
using System.Linq;
/*
 
 */
namespace _02._The_Lift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int waitingPeopleForTheLift = int.Parse(Console.ReadLine());

            int[] currentStateOfLift = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            bool isFull = false;
            bool noMorePeople = false;
            int allPeople = 0;

            for (int i = 0; i < currentStateOfLift.Length; i++)
            {
                for (int j = currentStateOfLift[i]; j < 4; j++)
                {
                    if (allPeople == waitingPeopleForTheLift)
                    {
                        noMorePeople = true;
                        break;
                    }

                    currentStateOfLift[i] += 1;
                    allPeople += 1;
                }

                if (noMorePeople)
                {
                    break;
                }
            }

            int[] finalStateOfTheLift = currentStateOfLift;

            for (int i = 0; i < finalStateOfTheLift.Length; i++)
            {
                if (finalStateOfTheLift[i] == 4)
                {
                    isFull = true;
                }
                else
                {
                    isFull = false;
                }
            }

            if (isFull && allPeople == waitingPeopleForTheLift)
            {
                Console.WriteLine(string.Join(' ', finalStateOfTheLift));
                return;
            }

            if (allPeople == waitingPeopleForTheLift)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(' ', finalStateOfTheLift));
            }
            else if (allPeople < waitingPeopleForTheLift)
            {
                Console.WriteLine($"There isn't enough space! {waitingPeopleForTheLift - allPeople} people in a queue!");
                Console.WriteLine(string.Join(' ', finalStateOfTheLift));
            }
        }
    }
}
