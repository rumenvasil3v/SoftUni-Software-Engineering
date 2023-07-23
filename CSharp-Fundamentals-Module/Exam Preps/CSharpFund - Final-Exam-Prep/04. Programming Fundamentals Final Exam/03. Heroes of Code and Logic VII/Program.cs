/*
4
Adela 90 150
SirMullich 70 40
Ivor 1 111
Tyris 94 61
Heal - SirMullich - 50
Recharge - Adela - 100
CastSpell - Tyris - 61 - Fireball
TakeDamage - Tyris - 99 - Fireball
TakeDamage - Ivor - 3 - Mosquito
End

 */

using System;
using System.Collections.Generic;

namespace Problem_3___Heroes_of_Code_and_Logic_VII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Hero> heroes = new Dictionary<string, Hero>();
            int numberOfLines = int.Parse(Console.ReadLine());

            for (int n = 0; n < numberOfLines; n++)
            {
                string[] heroStats = Console
                    .ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string heroName = heroStats[0];
                int heroHp = int.Parse(heroStats[1]);
                int heroMp = int.Parse(heroStats[2]);

                Hero hero = new Hero(heroName, heroHp, heroMp);

                heroes.Add(heroName, hero);
            }

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] arguments = input
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                string heroName = string.Empty;

                switch (arguments[0])
                {
                    case "CastSpell":
                        heroName = arguments[1];
                        int mpToCastSpell = int.Parse(arguments[2]);
                        string spellName = arguments[3];

                        if (mpToCastSpell <= heroes[heroName].ManaPoints)
                        {
                            heroes[heroName].ManaPoints -= mpToCastSpell;
                            Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroes[heroName].ManaPoints} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                        }
                        break;
                    case "TakeDamage":
                        heroName = arguments[1];
                        int damageTaken = int.Parse(arguments[2]);
                        string attacker = arguments[3];

                        heroes[heroName].HitPoints -= damageTaken;
                        if (heroes[heroName].HitPoints > 0)
                        {
                            Console.WriteLine($"{heroName} was hit for {damageTaken} HP by {attacker} and now has {heroes[heroName].HitPoints} HP left!");
                        }
                        else
                        {
                            heroes.Remove(heroName);
                            Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        }
                        break;
                    case "Recharge":
                        heroName = arguments[1];
                        int amountToRecharge = int.Parse(arguments[2]);

                        heroes[heroName].ManaPoints += amountToRecharge;
                        if (heroes[heroName].ManaPoints > 200)
                        {
                            Console.WriteLine($"{heroName} recharged for {amountToRecharge - (heroes[heroName].ManaPoints - 200)} MP!");
                            heroes[heroName].ManaPoints = 200;
                            break;
                        }

                        Console.WriteLine($"{heroName} recharged for {amountToRecharge} MP!");

                        break;
                    case "Heal":
                        heroName = arguments[1];
                        int amountToHeal = int.Parse(arguments[2]);

                        heroes[heroName].HitPoints += amountToHeal;
                        if (heroes[heroName].HitPoints > 100)
                        {
                            Console.WriteLine($"{heroName} healed for {amountToHeal - (heroes[heroName].HitPoints - 100)} HP!");
                            heroes[heroName].HitPoints = 100;
                            break;
                        }

                        Console.WriteLine($"{heroName} healed for {amountToHeal} HP!");
                        break;
                }
            }

            foreach (var kvp in heroes)
            {
                Console.WriteLine($"{kvp.Key}");
                Console.WriteLine($"  HP: {kvp.Value.HitPoints}");
                Console.WriteLine($"  MP: {kvp.Value.ManaPoints}");
            }
        }
    }

    public class Hero
    {

        public Hero(string name, int hp, int mp)
        {
            Name = name;
            HitPoints = hp;
            ManaPoints = mp;
        }

        public string Name { get; set; }

        public int HitPoints { get; set; }

        public int ManaPoints { get; set; }
    }
}