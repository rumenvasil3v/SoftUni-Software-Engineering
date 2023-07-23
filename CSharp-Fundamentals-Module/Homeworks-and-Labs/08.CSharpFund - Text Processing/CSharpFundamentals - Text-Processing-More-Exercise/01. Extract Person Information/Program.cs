/*
3
random name @lilly| random digits #5* age
@Marry| with age #19*
here Comes @Garry| he is #48* years old
 */

namespace _01._Extract_Person_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            for (int l = 0; l < numberOfLines; l++)
            {
                string text = Console.ReadLine();

                int nameFirstCharacter = text.IndexOf('@');
                int nameLastCharacter = text.IndexOf('|');

                string name = text.Substring(nameFirstCharacter + 1, nameLastCharacter - nameFirstCharacter - 1);

                int ageFirstCharacter = text.LastIndexOf('#');
                int ageLastCharacter = text.LastIndexOf('*');

                string age = text.Substring(ageFirstCharacter + 1, ageLastCharacter - ageFirstCharacter - 1);

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}