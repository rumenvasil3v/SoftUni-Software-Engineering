using System.Text;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console
                .ReadLine();

            StringBuilder sb = new StringBuilder();

            foreach (char character in text)
            {
                sb.Append((char)(character + 3));
            }

            string encryptedText = new string(sb.ToString());

            Console.WriteLine(encryptedText);
        }
    }
}