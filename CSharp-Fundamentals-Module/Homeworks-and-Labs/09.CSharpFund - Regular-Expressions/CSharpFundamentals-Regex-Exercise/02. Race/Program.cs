using System.Text.RegularExpressions;

namespace _02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> raceParticipants = Console
                .ReadLine()
                .Split(", ")
                .ToList();

            string alphabetCharacters = @"[A-Za-z]";
            string numberCharacters = @"[0-9]";

            Regex alphabetChRegex = new Regex(alphabetCharacters);
            Regex numericChRegex = new Regex(numberCharacters);

            List<Participant> racers = new List<Participant>();

            string input;
            while ((input = Console.ReadLine()) != "end of race")
            {
                MatchCollection numericMatch = numericChRegex.Matches(input);
                MatchCollection alphabeticalMatch = alphabetChRegex.Matches(input);

                string name = string.Empty;
                foreach (Match match in alphabeticalMatch)
                {
                    name += match.Value;
                }

                int distance = 0;
                foreach (Match match in numericMatch)
                {
                    distance += int.Parse(match.Value);
                }

                Participant participant = new Participant(name, distance);

                if (raceParticipants.Contains(name))
                {
                    var sameRacer = racers.FirstOrDefault(r => r.Name == name);
                    if (sameRacer != null)
                    {
                        sameRacer.Distance += distance;
                        continue;
                    }
                    racers.Add(participant);
                }
            }

            var orderedRacers = racers.OrderByDescending(x => x.Distance).ToArray();

            Console.WriteLine($"1st place: {orderedRacers[0].Name}");
            Console.WriteLine($"2nd place: {orderedRacers[1].Name}");
            Console.WriteLine($"3rd place: {orderedRacers[2].Name}");
        }
    }

    public class Participant
    {

        public Participant(string name, int distance)
        {
            Name = name;
            Distance = distance;
        }

        public string Name { get; set; }

        public int Distance { get; set; }
    }
}