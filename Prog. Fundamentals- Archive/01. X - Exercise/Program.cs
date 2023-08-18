namespace _01._X___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            int outerSpaces = 1;
            int innerSpaces = 4;
            int middleOfX = numberOfLines / 2;

            for (int n = 0; n <= numberOfLines / 2; n++)
            {
                if (n == 0)
                {
                    Console.Write("X");
                    Console.Write(new string(' ', numberOfLines - 2));
                    Console.WriteLine("X");
                    continue;
                }

                if (n == middleOfX)
                {
                    Console.Write(new string(' ', outerSpaces));
                    Console.WriteLine("X");
                    continue;
                }

                Console.Write(new string(' ', outerSpaces));
                Console.Write("X");
                Console.Write(new string(' ', numberOfLines - innerSpaces));
                Console.WriteLine("X");

                outerSpaces++;
                innerSpaces += 2;
            }

            for (int n2 = numberOfLines / 2; n2 <= numberOfLines - 2; n2++)
            {

                if (n2 == numberOfLines - 2)
                {
                    Console.Write("X");
                    Console.Write(new string(' ', numberOfLines - 2));
                    Console.WriteLine("X");
                    continue;
                }

                outerSpaces -= 1;
                innerSpaces -= 2;

                Console.Write(new string(' ', outerSpaces));
                Console.Write("X");
                Console.Write(new string(' ', numberOfLines - innerSpaces));
                Console.WriteLine("X");
            }
        }
    }
}