/*
4
STCEoghudd4=63333$D$0A53333
STCFoghudd4=63333$D$0A53333
STCDoghudd4=63333$D$0A53333
EHfsytsnhf?8555&I&2C9555SR

3
tt(''DGsvywgerx>6444444444%H%1B9444
GQhrr|A977777(H(TTTT
EHfsytsnhf?8555&I&2C9555SR
 */

using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[star]";

            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            List<Planet> planets = new List<Planet>();

            int numberOfLines = int.Parse(Console.ReadLine());
            for (int n = 1; n <= numberOfLines; n++)
            {
                string encryptedMessage = Console.ReadLine();
                MatchCollection matches = regex.Matches(encryptedMessage);

                int count = matches.Count;
                string currentPlanet = string.Empty;

                foreach (char character in encryptedMessage)
                {
                    int currentCharCode = character;
                    char currentChar = (char)(currentCharCode - count);

                    currentPlanet += currentChar;
                }

                string decryptedMessagePattern = @"\@(?<planetName>[A-Za-z]+)([^@\-!:>]*?):([^@\-!:>]*?)(?<planetPopulation>[0-9]+)([^@\-!:>]*?)!([^@\-!:>]*?)(?<attackType>[AD])([^@\-!:>]*?)!([^@\-!:>]*?)->([^@\-!:>]*?)(?<soldierCount>[0-9]+)";

                Match encryptedMatch = Regex.Match(currentPlanet, decryptedMessagePattern);
                if (!encryptedMatch.Success)
                {
                    continue;
                }

                string planetName = encryptedMatch.Groups["planetName"].Value;
                int planetPopulation = int.Parse(encryptedMatch.Groups["planetPopulation"].Value);
                char attackType = char.Parse(encryptedMatch.Groups["attackType"].Value);
                int soldierCount = int.Parse(encryptedMatch.Groups["soldierCount"].Value);

                Planet planet = new Planet(planetName, planetPopulation, attackType, soldierCount);
                planets.Add(planet);
            }

            var attackedPlanets = planets.Where(x => x.AttackType == 'A').ToList();
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (Planet planet in attackedPlanets.OrderBy(x => x.Name))
            {
                Console.WriteLine($"-> {planet.Name}");
            }

            var destroyedPlanets = planets.Where(x => x.AttackType == 'D').ToList();
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (Planet planet in destroyedPlanets.OrderBy(x => x.Name))
            {
                Console.WriteLine($"-> {planet.Name}");
            }
        }
    }

    public class Planet
    {

        public Planet(string name, int population, char attackType, int soldiers)
        {
            Name = name;
            Population = population;
            AttackType = attackType;
            Soldiers = soldiers;
        }

        public string Name { get; set; }

        public int Population { get; set; }

        public char AttackType { get; set; }

        public int Soldiers { get; set; }
    }
}