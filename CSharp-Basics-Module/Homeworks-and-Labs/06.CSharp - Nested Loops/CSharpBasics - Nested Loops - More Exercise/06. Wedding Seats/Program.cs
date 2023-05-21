using System;

namespace _06._Wedding_Seats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char lastSector = char.Parse(Console.ReadLine());
            int rowsFirstSector = int.Parse(Console.ReadLine());
            int oddRowPlaces = int.Parse(Console.ReadLine());

            int places = 0;
            char place = 'a';

            for (char i = 'A'; i <= lastSector; i++)
            {
                for (int rows = 1; rows <= rowsFirstSector; rows++)
                {
                    for (int rowPlace = 1; rowPlace <= rowsFirstSector; rowPlace++)
                    {
                        if (rows % 2 !=  0)
                        {
                            for (int p = 1; p <= oddRowPlaces; p++)
                            {
                                Console.WriteLine($"{i}{rows}{place}");
                                place++;
                                places++;
                            }
                        }
                        else 
                        {
                            for (int p2 = 1; p2 <= oddRowPlaces + 2; p2++)
                            {
                                Console.WriteLine($"{i}{rows}{place}");
                                place++;
                                places++;
                            }
                        }
                        place = 'a';
                        rows++;
                    }
                }
                rowsFirstSector++;
            }
            Console.WriteLine(places);
        }
    }
}
