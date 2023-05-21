using System;

namespace _04._Vacation_Books_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. We read from the console number pages for one book.
            int pages = int.Parse(Console.ReadLine());
            //2.We read from the console pages per hour that Joro read. 
            int pagesHour = int.Parse(Console.ReadLine());
            //
            int daysForBook = int.Parse(Console.ReadLine());

            Console.WriteLine(pages / pagesHour /daysForBook );
        }
    }
}
