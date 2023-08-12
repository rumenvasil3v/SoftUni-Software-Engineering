/*
4
register Jony AA4132BB
register Jony AA4206BB
register Linda AA9999BB
unregister Jony
 */

namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, User> users = new Dictionary<string, User>();

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int u = 0; u < numberOfCommands; u++)
            {
                string[] arguments = Console
                    .ReadLine()
                    .Split(' ');

                string command = arguments[0];
                string userName = arguments[1];

                switch (command)
                {
                    case "register":
                        string licensePlateNumber = arguments[2];
                        User user = new User(userName, licensePlateNumber);

                        if (!users.ContainsKey(user.Name))
                        {
                            users[user.Name] = user;
                            Console.WriteLine($"{user.Name} registered {user.LicensePlateNumber} successfully");
                            break;
                        }

                        Console.WriteLine($"ERROR: already registered with plate number {users[user.Name].LicensePlateNumber}");
                        break;
                    case "unregister":
                        if (users.ContainsKey(userName))
                        {
                            users.Remove(userName);
                            Console.WriteLine($"{userName} unregistered successfully");
                            break;
                        }

                        Console.WriteLine($"ERROR: user {userName} not found");
                        break;
                }
            }

            foreach (User user in users.Values)
            {
                Console.WriteLine(user);
            }
        }
    }

    public class User
    {

        public User(string name, string licensePlateNumber)
        {
            this.Name = name;
            this.LicensePlateNumber = licensePlateNumber;
        }

        public string Name { get; set; }

        public string LicensePlateNumber { get; set; }

        public override string ToString()
        {
            return String.Format("{0} => {1}", this.Name, this.LicensePlateNumber);
        }
    }
}