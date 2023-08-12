/*
Legolas <:> Red <:> 5000
Peter <:> Blue <:> 10000
Peter <:> Red <:> 10000
Gimli <:> Red <:> 5000
George <:> Red <:> 5000
George <:> Blue <:> 10000
Rumen <:> Blue <:> 10000
Ork <:> Yellow <:> 20000
Ork <:> Purple <:> 20000
Once upon a time
 */

namespace _04._Snowwhite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var newDwarf = new Dictionary<string, Dwarf>();
            Dictionary<string, Dictionary<string, Dwarf>> dwarves = new Dictionary<string, Dictionary<string, Dwarf>>();
            string input;
            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                string[] arguments = input
                    .Split(" <:> ");

                string dwarfName = arguments[0];
                string dwarfHatColor = arguments[1];
                int dwarfPhysics = int.Parse(arguments[2]);

                Dwarf dwarf = new Dwarf(dwarfHatColor, dwarfName, dwarfPhysics);

                if (!dwarves.ContainsKey(dwarfHatColor))
                {
                    newDwarf.Add(dwarf.Name, dwarf);

                    dwarves.Add(dwarfHatColor, newDwarf);
                    newDwarf = new Dictionary<string, Dwarf>();
                    continue;
                }

                if (dwarves[dwarfHatColor].ContainsKey(dwarf.Name))
                {
                    if (dwarves[dwarfHatColor][dwarf.Name].Physics < dwarf.Physics)
                    {
                        dwarves[dwarfHatColor][dwarf.Name].Physics = dwarf.Physics;
                    }
                }
                else
                {
                    dwarves[dwarfHatColor].Add(dwarf.Name, dwarf);
                }
            }

            List<Dwarf> orderedDwarves = new List<Dwarf>();

            foreach (var dwarf in dwarves)
            {
                string color = dwarf.Key;

                foreach (var d in dwarf.Value)
                {
                    string name = d.Value.Name;
                    int physics = d.Value.Physics;

                    Dwarf currentDwarf = new Dwarf(color, name, physics);

                    orderedDwarves.Add(currentDwarf);
                }
            }

            foreach (var dwarf in orderedDwarves
                         .OrderByDescending(d => d.Physics)
                         .ThenByDescending(d => orderedDwarves.Count(x => x.Color == d.Color)))
            {
                Console.WriteLine($"({dwarf.Color}) {dwarf.Name} <-> {dwarf.Physics}");
            }
        }
    }

    public class Dwarf
    {
        
        public Dwarf(string col, string name, int physics)
        {
            Color = col;
            Name = name;
            Physics = physics;
        }

        public string Name { get; set; }

        public int Physics { get; set; }

        public string Color { get; set; }
    }
}