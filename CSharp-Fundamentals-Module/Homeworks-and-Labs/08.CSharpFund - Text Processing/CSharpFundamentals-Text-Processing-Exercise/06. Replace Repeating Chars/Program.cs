using System.Text;

namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console
                .ReadLine();

            StringBuilder sb = new StringBuilder ();

            for (int c = 0; c < text.Length; c++)
            {

                if (c == text.Length - 1)
                {
                    sb.Append(text[c]);
                    break;
                }

                if (text[c] != text[c + 1])
                {
                    sb.Append(text[c]);
                }
            }

            string result = new string(sb.ToString());

            Console.WriteLine(result);
        }
    }
}