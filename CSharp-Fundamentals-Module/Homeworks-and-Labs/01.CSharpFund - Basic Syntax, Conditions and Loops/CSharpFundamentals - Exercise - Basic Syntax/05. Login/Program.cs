using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            StringBuilder reverse = new StringBuilder();

            for (int i = username.Length - 1; i >= 0; i--)
            {
                reverse.Append(username[i]);
            }

            string usernameReversed = reverse.ToString();
            int attempts = 0;

            string password;
            while ((password = Console.ReadLine()) != $"{usernameReversed}")
            {
                if (password != usernameReversed)
                {
                    attempts++;
                    if (attempts == 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }

            if (password == usernameReversed)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
