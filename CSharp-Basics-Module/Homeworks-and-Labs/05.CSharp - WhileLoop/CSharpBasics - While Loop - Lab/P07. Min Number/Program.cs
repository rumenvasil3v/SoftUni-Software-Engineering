using System;

namespace P07._Min_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minNum = int.MaxValue;
            int currNumber = 0;
            string text = Console.ReadLine();

            while(true)
            {
                if (text != "Stop")
                {
                    currNumber = int.Parse(text);
                    if (currNumber < minNum)
                    {
                        minNum = currNumber;
                    }
                    
                }
                else
                {
                    Console.WriteLine(minNum);
                    break;
                }
                text= Console.ReadLine();
            }   
        }
    }
}
