using System;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pre = 5;
            int post = 5;

            Console.WriteLine(++pre);
            Console.WriteLine(pre);

            Console.WriteLine(post++);
            Console.WriteLine(post);
        }
    }
}
