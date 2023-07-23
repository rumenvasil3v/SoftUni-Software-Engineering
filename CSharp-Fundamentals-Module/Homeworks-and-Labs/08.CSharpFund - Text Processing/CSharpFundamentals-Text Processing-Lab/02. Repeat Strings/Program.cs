using System.Text;

namespace _02._Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console
                .ReadLine()
                .Split(' ');

            StringBuilder sb = new StringBuilder();

            foreach (string word in words)
            {
                
                foreach (char ch in word)
                {
                    sb.Append(word);
                }
            }

            Console.WriteLine(sb);
        }
    }
}