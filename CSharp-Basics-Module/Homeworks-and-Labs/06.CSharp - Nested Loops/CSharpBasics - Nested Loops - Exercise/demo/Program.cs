using System;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string currentNum = num.ToString();

            for (int i = 0; i < currentNum.Length; i++)
            {
                Console.WriteLine($"curreNum[{i}] = {currentNum[i]}");
            }
        }
    }
}

//100034

//цифтите на четни позиции са: 1 0 3 => evenSum = 49 + 48 + 51 = 148
//цифрите на нечетни позиции са: 0 0 4 => oddSum = 48 + 48 + 52 = 148
