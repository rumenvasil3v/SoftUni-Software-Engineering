/*
Peter -> OOP -> 350
George -> OOP -> 250
Sam -> Advanced -> 600
George -> OOP -> 240
John -> OOP -> 300
John -> Advanced -> 250
Anna -> JSCore -> 400
no more time
 */
using System.Linq;

namespace _02._Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Contest> contests = new Dictionary<string, Contest>();
            Dictionary<string, IndividualUser> individualUsers = new Dictionary<string, IndividualUser>();
            string input;
            while ((input = Console.ReadLine()) != "no more time")
            {
                string[] arguments = input
                    .Split(" -> ");

                string userName = arguments[0];
                string contestName = arguments[1];
                int userPoints = int.Parse(arguments[2]);

                Contest contest = new Contest(contestName);
                User user = new User(userName, userPoints);
                IndividualUser iniIndividualUser = new IndividualUser(userName, userPoints);

                if (!individualUsers.ContainsKey(iniIndividualUser.Name))
                {
                    individualUsers[user.Name] = iniIndividualUser;
                }
                else
                {
                    individualUsers[user.Name].Points += userPoints;
                }

                if (!contests.ContainsKey(contest.Name))
                {
                    contest.Users.Add(user.Name, user);
                    contests.Add(contest.Name, contest);
                    continue;
                }

                if (contests[contest.Name].Users.ContainsKey(user.Name))
                {
                    if (contests[contest.Name].Users[user.Name].Points < userPoints)
                    {
                        contests[contest.Name].Users[user.Name].Points = userPoints;
                        individualUsers[user.Name].Points = userPoints;
                    }
                    else
                    {
                        individualUsers[user.Name].Points -= userPoints;
                    }
                }
                else
                {
                    contests[contest.Name].Users.Add(user.Name, user);
                }
            }

            foreach (Contest contest in contests.Values)
            {
                Console.WriteLine(contest.ToString().Trim());
            }

            int position = 1;
            Console.WriteLine("Individual standings:");
            foreach (IndividualUser user in individualUsers.Values.OrderByDescending(u => u.Points).ThenBy(u => u.Name))
            {
                Console.WriteLine($"{position}. {user.Name} -> {user.Points}");
                position++;
            }
        }
    }

    public class Contest
    {

        public Contest(string name)
        {
            Name = name;
            Users = new Dictionary<string, User>();
        }

        public string Name { get; set; }

        public Dictionary<string, User> Users { get; set; }

        public override string ToString()
        {
            int position = 1;
            string result = string.Empty;

            result += $"{this.Name}: {this.Users.Count} participants\n";

            foreach (User user in this.Users.Values.OrderByDescending(u => u.Points).ThenBy(u => u.Name))
            {
                result += $"{position}. {user.Name} <::> {user.Points}\n";
                position++;
            }

            return result;
        }
    }

    public class User
    {

        public User(string name, int points)
        {
            Name = name;
            Points = points;
        }

        public string Name { get; set; }

        public int Points { get; set; }

    }

    public class IndividualUser
    {
        public IndividualUser(string name, int points)
        {
            Name = name;
            Points = points;
        }

        public string Name { get; set; }

        public int Points { get; set; }
    }
}