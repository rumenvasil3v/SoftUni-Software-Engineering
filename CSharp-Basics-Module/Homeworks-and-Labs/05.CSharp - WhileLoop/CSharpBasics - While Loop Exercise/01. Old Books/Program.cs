using System;

namespace _01._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //1. Read from the console, favourite book.
            string favouriteBook = Console.ReadLine();

            int count = 0;
            string input = Console.ReadLine();

            //2. Read while loop, which will iterate
            // while we check all books
            while (input != "No More Books" && favouriteBook != input)
            {
                //=> check wether is the favourite books
                if (input == favouriteBook)
                {
                    //=> if it is: break loop;
                    break;
                }

                //=> if it is not: increase the sum of the books, which we checked with 1.
                count++;
                //=> Read from the console title of the next book
                input = Console.ReadLine();
            }

            //3. Bring out exit on the console
            if (input == favouriteBook)
            {
                // => if we found the book
                Console.WriteLine($"You checked {count} books and found it.");
            }
            else
            {
                // => if we didn't found the book
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {count} books.");
            }


        }
    }
}
