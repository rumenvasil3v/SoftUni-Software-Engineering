/*
Peter -> Adc -> 400
Peter -> Adc -> 450
Bush -> Tank -> 150
Faker -> Mid -> 200
Faker -> Support -> 250
Faker -> Tank -> 250
Season end
 */

namespace _03._MOBA_Challenger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Player> players = new Dictionary<string, Player>();
            string input;
            while ((input = Console.ReadLine()) != "Season end")
            {
                string[] arguments = input
                    .Split(" -> ");

                if (arguments.Length == 1)
                {
                    arguments = input
                        .Split(" vs ");

                    string firstPlayer = arguments[0];
                    string secondPlayer = arguments[1];

                    if (players.ContainsKey(firstPlayer) && players.ContainsKey(secondPlayer))
                    {
                        int firstPlayerTotalSkillPoints = 0;
                        int secondPlayerTotalSkillPoints = 0;
                        foreach (var fSkill in players[firstPlayer].Positions.Values)
                        {
                            firstPlayerTotalSkillPoints += fSkill.Skill;
                        }

                        foreach (var sSkill in players[secondPlayer].Positions.Values)
                        {
                            secondPlayerTotalSkillPoints += sSkill.Skill;
                        }
                        bool samePosition = false;

                        foreach (var fPlayer in players[firstPlayer].Positions.Values)
                        {
                            foreach (var sPlayer in players[secondPlayer].Positions.Values)
                            {
                                if (fPlayer.Name == sPlayer.Name)
                                {
                                    if (firstPlayerTotalSkillPoints > secondPlayerTotalSkillPoints)
                                    {
                                        players.Remove(secondPlayer);
                                    }
                                    else if (firstPlayerTotalSkillPoints < secondPlayerTotalSkillPoints)
                                    {
                                        players.Remove(firstPlayer);
                                    }
                                    samePosition = true;
                                    break;
                                }
                            }

                            if (samePosition)
                            {
                                break;
                            }
                        }

                        continue;
                    }
                    else
                    {
                        continue;
                    }
                }

                string currentPlayer = arguments[0];
                string currentPostition = arguments[1];
                int skill = int.Parse(arguments[2]);

                Player player = new Player(currentPlayer);
                Position position = new Position(currentPostition, skill);

                if (!players.ContainsKey(player.Name))
                {
                    player.Positions.Add(position.Name, position);
                    players.Add(player.Name, player);
                    continue;
                }

                if (players[player.Name].Positions.ContainsKey(position.Name))
                {
                    if (players[player.Name].Positions[position.Name].Skill < position.Skill)
                    {
                        players[player.Name].Positions[position.Name].Skill = position.Skill;
                    }
                }
                else
                {
                    players[player.Name].Positions.Add(position.Name, position);
                }
            }

            //var myList = players.Values.OrderByDescending(p => p.Positions.Values.Sum(s => s.Skill)); 

            foreach (Player player in players.Values.OrderByDescending(p => p.Positions.Values.Sum(s => s.Skill)).ThenBy(p => p.Name))
            {
                string result = string.Empty;

                result += $"{player.Name}: {player.Positions.Values.Sum(s => s.Skill)} skill\n";

                foreach (Position position in player.Positions.Values.OrderByDescending(s => s.Skill).ThenBy(p => p.Name))
                {
                    result += $"- {position.Name} <::> {position.Skill}\n";
                }

                Console.WriteLine(result.Trim());
            }
        }
    }

    public class Player
    {

        public Player(string name)
        {
            Name = name;
            Positions = new Dictionary<string, Position>();
        }

        public string Name { get; set; }

        public Dictionary<string, Position> Positions { get; set; }
    }

    public class Position
    {

        public Position(string name, int skill)
        {
            Name = name;
            Skill = skill;
        }

        public string Name { get; set; }

        public int Skill { get; set; }
    }
}