using System.Reflection;

namespace _05._Drum_Set
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal savings = decimal.Parse(Console.ReadLine());

            List<int> drumSet = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> copyOfTheDrumSet = new List<int>();
            for (int n = 0; n < drumSet.Count; n++)
            {
                copyOfTheDrumSet.Add(drumSet[n]);
            }

            string command;
            while ((command = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int hitPowerOnEachDrum = int.Parse(command);

                if (hitPowerOnEachDrum == 0)
                {
                    continue;
                }

                for (int d = 0; d < drumSet.Count; d++)
                {
                    drumSet[d] -= hitPowerOnEachDrum;

                    if (drumSet[d] <= 0)
                    {
                        decimal priceForNewDrum = copyOfTheDrumSet[d] * 3;
                        if (savings - priceForNewDrum >= 0)
                        {
                            savings -= priceForNewDrum;
                            drumSet[d] = copyOfTheDrumSet[d];
                        }
                        else
                        {
                            copyOfTheDrumSet.RemoveAt(d);
                            drumSet.RemoveAt(d);
                            d--;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", drumSet));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}