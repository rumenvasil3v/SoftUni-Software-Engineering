using System.Runtime.InteropServices;
using System.Text;

namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = Console
                .ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            StringBuilder sb = new StringBuilder();

            foreach (string userName in userNames)
            {
                if (userName.Length >= 3 && userName.Length <= 16)
                {
                    bool isValidUsername = userName.All(u => char.IsLetterOrDigit(u) || u == '-' || u == '_');

                    if (isValidUsername)
                    {
                        sb.AppendLine(userName);
                    }
                }
            }

            string validUsernames = new string(sb.ToString());

            Console.WriteLine(validUsernames);

            //Console.WriteLine(sb);
        }
    }
}