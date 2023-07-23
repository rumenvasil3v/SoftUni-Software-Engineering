using System;
using System.Collections.Generic;

namespace _07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrays = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);

            List<string> concatArrays = new List<string>();

            for (int i = arrays.Length - 1; i >= 0; i--)
            {
                string[] tokens = arrays[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < tokens.Length; j++)
                {
                    concatArrays.Add(tokens[j]);
                }
            }

            Console.WriteLine(string.Join(' ', concatArrays));
        }
    }
}
