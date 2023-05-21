using System;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string number = n.ToString();

            for (int i = 0; i < number.Length; i++)
            {
                int currentDigit = number[i];
                Console.WriteLine(currentDigit);
            }
        }
    }
}
