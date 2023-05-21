using System;

namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Read from the console start and end of diapazone
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            //2. Read from the console magic number
            int magicNum = int.Parse(Console.ReadLine());
            //3. Make variable for the combinations
            int combinations = 0;

            bool flag = false;
            //4. Create nested loops, which find possible combinations in diapazone
            for (int x1 = start; x1 <= end ; x1++)
            {
                for (int x2 = start; x2 <= end; x2++)
                {
                    combinations++;
                    
                    int result = x1 + x2;

                    if (result == magicNum)
                    {
                        Console.WriteLine($"Combination N:{combinations} ({x1} + {x2} = {magicNum})");
                        flag = true;
                        break;
                    }
                }

                if (flag)
                {
                    break;
                }
            }

            if (!flag)
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicNum}");
            }
        }
    }
}
