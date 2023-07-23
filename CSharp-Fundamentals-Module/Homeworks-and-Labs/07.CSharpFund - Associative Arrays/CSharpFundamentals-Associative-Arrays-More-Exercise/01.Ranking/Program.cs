/*

 */

namespace _01.Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Contest> contests = new Dictionary<string, Contest>(); // define instance of Dictionary
            string input;
            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] arguments = input
                    .Split(':');

                string currentContest = arguments[0];
                string passwordForContest = arguments[1];

                Contest contest = new Contest(currentContest, passwordForContest);

                if (!contests.ContainsKey(contest.Name))
                {
                    contests.Add(contest.Name, contest);
                }
            }

            SortedDictionary<string, User> users = new SortedDictionary<string, User>();
            string submissions;
            while ((submissions = Console.ReadLine()) != "end of submissions")
            {
                string[] arguments = submissions
                    .Split("=>");

                string currentContest = arguments[0];
                string currentPassword = arguments[1];
                string currentUserName = arguments[2];
                int currentPoints = int.Parse(arguments[3]);

                Point point = new Point(currentContest, currentPoints);
                User user = new User(currentUserName, currentPoints);

                if (contests.ContainsKey(point.ContestName))
                {
                    if (contests[point.ContestName].Password == currentPassword)
                    {
                        if (!users.ContainsKey(user.Name))
                        {
                            user.Contests.Add(point.ContestName, point);
                            users[user.Name] = user;
                            continue;
                        }

                        if (!users[user.Name].Contests.ContainsKey(point.ContestName))
                        {
                            users[user.Name].Contests.Add(point.ContestName, point);
                            continue;
                        }

                        if (users[user.Name].Contests[point.ContestName].Points < point.Points)
                        {
                            users[user.Name].Contests[point.ContestName].Points = point.Points;
                        }
                    }
                }
            }

            int bestCandidatePoints = users.Values.Max(m => m.Contests.Values.Sum(m => m.Points));

            foreach (var user in users.Values)
            {
                if (user.Contests.Values.Sum(p => p.Points) == bestCandidatePoints)
                {
                    Console.WriteLine($"Best candidate is {user.Name} with total {bestCandidatePoints} points.");
                }
            }

            Console.WriteLine("Ranking: ");
            foreach (User user in users.Values)
            {
                Console.WriteLine(user.ToString().Trim());
            }
        }
    }

    public class Contest
    {

        public Contest(string name, string password)
        {
            Name = name;
            Password = password;
        }

        public string Name { get; set; }

        public string Password { get; set; }

    }

    public class User
    {

        public User(string name, int points)
        {
            Name = name;
            Contests = new Dictionary<string, Point>();
        }

        public string Name { get; set; }

        public Dictionary<string, Point> Contests { get; set; }

        public override string ToString()
        {
            string result = string.Empty;

            result += $"{this.Name}\n";

            foreach (var course in this.Contests.Values.OrderByDescending(p => p.Points))
            {
                result += $"#  {course.ContestName} -> {course.Points}\n";
            }

            return result;
        }
    }

    public class Point
    {

        public Point(string contestName, int points)
        {
            ContestName = contestName;
            Points = points;
        }

        public string ContestName { get; set; }

        public int Points { get; set; }
    }
}