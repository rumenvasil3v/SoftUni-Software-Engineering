using System;

namespace _01._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short firstNum = short.Parse(Console.ReadLine());
            short secondNum = short.Parse(Console.ReadLine());
            secondNum = (short)(firstNum + secondNum);

            short thirdNum = short.Parse(Console.ReadLine());
            secondNum = (short)(secondNum / thirdNum);
            
            short fourthNum = short.Parse(Console.ReadLine());
            secondNum = (short)(secondNum * fourthNum);

            Console.WriteLine(secondNum);
        }
    }
}
