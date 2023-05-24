using System;

namespace _01._Data_Type_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            while (input != "END")
            {
                string dataType = string.Empty;

                bool isValid = false;
                bool trueOrFalse = false;
                isValid = bool.TryParse(input, out trueOrFalse);
                
                char ch = '\0';
                bool character = false;
                character = char.TryParse(input, out ch);

                int integerNum = 0;
                bool integer = false;
                integer = int.TryParse(input, out integerNum);

                double floatingPointNum = 0.0;
                bool floatingNum = false;
                floatingNum = double.TryParse(input, out floatingPointNum);

                if (integer)
                {
                    dataType = "integer";
                    Console.WriteLine($"{input} is {dataType} type");
                }
                else if (floatingNum)
                {
                    dataType = "floating point";
                    Console.WriteLine($"{input} is {dataType} type");
                }
                else if (character)
                {
                    dataType = "character";
                    Console.WriteLine($"{input} is {dataType} type");
                }
                else if (isValid)
                {
                    dataType = "boolean";
                    Console.WriteLine($"{input} is {dataType} type");
                }
                else
                {
                    dataType = "string";
                    Console.WriteLine($"{input} is {dataType} type");
                }

                input = Console.ReadLine();
            }
        }
    }
}
