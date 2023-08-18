using System;
/*
 Hey hello 2 4
10 hey 4 hello

S of t un i
of i 10 un

i love to code
code i love to
 */
namespace _02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ');
            string[] secondArray = Console.ReadLine().Split(' ');

            for (int i = 0; i < secondArray.Length; i++)
            {
                for (int j = 0; j < firstArray.Length; j++)
                {
                    if (firstArray[j] == secondArray[i])
                    {
                        Console.Write(secondArray[i] + " ");
                        break;
                    }
                }
            }
        }
    }
}
