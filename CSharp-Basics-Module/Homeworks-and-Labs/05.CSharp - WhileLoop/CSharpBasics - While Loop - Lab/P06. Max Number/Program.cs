using System;

namespace P06._Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int maxNum = int.MinValue;
            while (text != "Stop")
            {
                text = Console.ReadLine();
                bool canParse = int.TryParse(text, out int currentNum);
                if (!canParse)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                else
                {
                    if (currentNum > maxNum)
                    {
                        maxNum = currentNum;
                    }
                }
            }
            Console.WriteLine(maxNum);
        }
    }
}
