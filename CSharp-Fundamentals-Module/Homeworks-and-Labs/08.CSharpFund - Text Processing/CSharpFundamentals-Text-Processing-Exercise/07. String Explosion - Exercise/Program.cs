using System.Text;

namespace _07._String_Explosion___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            int strength = 0;

            for (int t = 0; t < text.Length; t++)
            {
                if (text[t] == '>')
                {
                    sb.Append(text[t]);

                    strength += int.Parse(text[t + 1].ToString());
                }
                else if (strength == 0)
                {
                    sb.Append(text[t]);
                }
                else
                {
                    strength--;
                }
            }

            string finalResult = new string(sb.ToString());

            Console.WriteLine(finalResult);
        }
    }
}