/*
M3ph1st0**, Azazel,      Izrael 
M3ph1st0**, Azazel
 */

using System.Text.RegularExpressions;

namespace _05._Nether_Realms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string healthPattern = @"[^0-9+/\-*.]";

            Regex healthRegex = new Regex(healthPattern);
            List<Demon> demons = new List<Demon>();

            char[] separators = new char[] {',', ' ' };
            string[] text = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach (string demon in text)
            {
                MatchCollection healthMatches = healthRegex.Matches(demon);

                int health = 0;
                foreach (Match character in healthMatches)
                {
                    char currentCharacterValue = char.Parse(character.Value);
                    health += currentCharacterValue;
                }

                string damagePattern = @"([-+]?[0-9]*\.?[0-9]+)";

                Regex damageRegex = new Regex(damagePattern);
                MatchCollection damageMatches = damageRegex.Matches(demon);
                double damage = 0.0;
                foreach (Match match in damageMatches)
                {
                    damage += double.Parse(match.Value);
                }

                string arithmeticOperationSignPattern = @"[*/]";
                Regex arithmeticRegex = new Regex(arithmeticOperationSignPattern);
                MatchCollection arithmeticMatches = arithmeticRegex.Matches(demon);
                foreach (Match match in arithmeticMatches)
                {
                    if (match.Value == "/")
                    {
                        damage /= 2;
                    }
                    else if (match.Value == "*")
                    {
                        damage *= 2;
                    }
                }

                Demon currentDemon = new Demon(demon, health, damage);

                demons.Add(currentDemon);
            }

            foreach (Demon demon in demons.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:F2} damage");
            }
        }
    }

    public class Demon
    {

        public Demon(string name, int health, double damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        public string Name { get; set; }

        public int Health { get; set; }

        public double Damage { get; set; } 
    }
}