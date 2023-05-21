using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _04._Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] reversedText = text.ToCharArray();

            for (int i = text.Length - 1; i >= 0; i--)
            {
                Console.Write(reversedText[i]);
            }
        }
    }
}
