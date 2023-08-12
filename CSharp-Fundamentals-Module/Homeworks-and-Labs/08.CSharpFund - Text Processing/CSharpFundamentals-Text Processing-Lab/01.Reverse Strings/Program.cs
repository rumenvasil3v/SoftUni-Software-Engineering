namespace _01.Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                char[] characters = input.ToCharArray();
                Array.Reverse(characters);

                string reversedWord = new string(characters);

                Console.WriteLine($"{input} = {reversedWord}");
            }
        }
    }
}