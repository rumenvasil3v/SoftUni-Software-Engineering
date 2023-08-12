namespace _05._Teamwork_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            int countOfTeams = int.Parse(Console.ReadLine());
            for (int t = 0; t < countOfTeams; t++)
            {
                args = Console
                    .ReadLine()
                    .Split('-', StringSplitOptions.RemoveEmptyEntries);

                string creatorOfTeam = args[0];
                string teamName = args[1];

                Team team = new Team(creatorOfTeam, teamName);

                Team exist = teams.FirstOrDefault(t => t.Name == teamName);
                if (exist != null)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                Team creatorExist = teams.FirstOrDefault(t => t.Creator == creatorOfTeam);
                if (creatorExist != null)
                {
                    Console.WriteLine($"{creatorOfTeam} cannot create another team!");
                    continue;
                }

                Console.WriteLine($"Team {teamName} has been created by {creatorOfTeam}!");

                teams.Add(team);
            }

            string input;
            while ((input = Console.ReadLine()) != "end of assignment")
            {
                args = input.Split("->");

                string memberTeam = args[0];
                string currentTeam = args[1];

                Team nonExist = teams.Find(t => t.Name == currentTeam);
                if (nonExist == null)
                {
                    Console.WriteLine($"Team {currentTeam} does not exist!");
                    continue;
                }

                Team member = teams.FirstOrDefault(m => m.Creator == memberTeam);
                if (member != null)
                {
                    Console.WriteLine($"Member {memberTeam} cannot join team {currentTeam}!");
                    continue;
                }

                bool exist = false;
                foreach (Team team in teams)
                {
                    if (team.DoesMemberExist(memberTeam))
                    {
                        Console.WriteLine($"Member {memberTeam} cannot join team {currentTeam}!");
                        exist = true;
                        break;
                    }
                }

                if (exist)
                {
                    continue;
                }

                foreach (Team current in teams)
                {
                    if (current.Name == currentTeam)
                    {
                        current.Members.Add(memberTeam);
                        break;
                    }
                }
            }

            List<Team> validTeams = teams
                .Where(t => t.Members.Count > 0)
                .ToList();

            List<Team> teamsWithNoMembers = teams
                .Where(t => t.Members.Count == 0)
                .ToList();

            foreach (Team team in validTeams.OrderByDescending(t => t.Members.Count).ThenBy(t => t.Name))
            {
                Console.WriteLine(team.ToString().Trim());
            }

            Console.WriteLine("Teams to disband:");
            foreach (Team disband in teamsWithNoMembers.OrderBy(t => t.Name))
            {
                Console.WriteLine(disband.Name);
            }
        }
    }

    public class Team
    {

        public Team(string creator, string name)
        {
            this.Name = name;
            this.Creator = creator;
            this.Members = new List<string>();
        }

        public string Name { get; set; }

        public string Creator { get; set; }

        public List<string> Members { get; set; }

        public override string ToString()
        {
            this.Members.Sort();

            string result = string.Empty;

            result += $"{this.Name}\n";
            result += $"- {this.Creator}\n";
            foreach (string member in this.Members)
            {
                result += $"-- {member}\n";
            }

            return result;
        }

        public bool DoesMemberExist(string member)
        {
            foreach (string m in this.Members)
            {
                if (m == member)
                {
                    return true;
                }
            }

            return false;
        }
    }
}