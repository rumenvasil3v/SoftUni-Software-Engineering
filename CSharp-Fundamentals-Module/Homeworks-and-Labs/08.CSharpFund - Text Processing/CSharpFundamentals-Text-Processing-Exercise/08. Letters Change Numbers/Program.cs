namespace _08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] texts = Console
                .ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double finalResult = 0;

            foreach (string text in texts)
            {
                int charPosition = 1;

                foreach (char character in text)
                {
                    string number = string.Join("", text.ToCharArray().Where(char.IsDigit));

                    double currentNumber = double.Parse(number);
                    if (charPosition == 1)
                    {
                        if (char.IsLetter(character) && char.IsUpper(character))
                        {
                            //char c = 'b'; you may use lower case character.
                            int position = char.ToUpper(character) - 64;

                            finalResult += currentNumber / position;
                        }
                        else if (char.IsLetter(character) && char.IsLower(character))
                        {
                            int position = char.ToUpper(character) - 64;

                            finalResult += currentNumber * position;
                        }

                        charPosition++;
                    }
                    else if (charPosition == 2)
                    {
                        if (char.IsLetter(character) && char.IsUpper(character))
                        {
                            //char c = 'b'; you may use lower case character.
                            int position = char.ToUpper(character) - 64;

                            finalResult -= position;
                        }
                        else if (char.IsLetter(character) && char.IsLower(character))
                        {
                            int position = char.ToUpper(character) - 64;

                            finalResult += position;
                        }
                    }
                }
            }

            Console.WriteLine($"{finalResult:F2}");
        }
    }
}