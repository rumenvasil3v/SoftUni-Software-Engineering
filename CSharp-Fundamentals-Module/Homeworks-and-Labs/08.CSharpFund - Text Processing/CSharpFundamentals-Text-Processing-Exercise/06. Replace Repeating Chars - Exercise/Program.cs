using System.Text;

namespace _06._Replace_Repeating_Chars___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console
                .ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append(text);

            int startBorder = 0;
            int endBorder = 0;

            int index = 0;
            for (int c = 0; c < text.Length; c++)
            {
                endBorder++;

                if (c == text.Length - 1)
                {
                    string subString = text.Substring(startBorder, endBorder);
                    sb.Replace(subString, text[c].ToString());
                    break;
                }

                if (text[c] != text[c + 1])
                {

                    string subString = text.Substring(startBorder, endBorder);

                    startBorder = c + 1;
                    endBorder = 0;

                    sb.Replace(subString, text[c].ToString());
                }
            }

            string finalResult = new string(sb.ToString());

            Console.WriteLine(finalResult);
        }
    }
}