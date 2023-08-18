namespace _05._Dragon_Army
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Type> dragons = new Dictionary<string, Type>();

            int numberOfDragons = int.Parse(Console.ReadLine());

            for (int n = 0; n < numberOfDragons; n++)
            {
                string[] dragonData = Console.ReadLine().Split();

                string colorType = dragonData[0];
                string nameOfDragon = dragonData[1];
                bool damageDragonMakes = int.TryParse(dragonData[2], out int damage);
                if (damageDragonMakes == false)
                {
                    damage = 45;
                }
                bool healthOfDragon = int.TryParse(dragonData[3], out int health);
                if (healthOfDragon == false)
                {
                    health = 250;
                }
                bool armorOfDragon = int.TryParse(dragonData[4], out int armor);
                if (armorOfDragon == false)
                {
                    armor = 10;
                }

                Type type = new Type(colorType);
                Dragon dragon = new Dragon(nameOfDragon, health, armor, damage);

                if (!dragons.ContainsKey(type.Color))
                {
                    type.Dragons.Add(dragon.Name, dragon);
                    dragons.Add(type.Color, type);
                    continue;
                }

                if (dragons[type.Color].Dragons.ContainsKey(dragon.Name))
                {
                    dragons[type.Color].Dragons[dragon.Name].Armor = dragon.Armor;
                    dragons[type.Color].Dragons[dragon.Name].Health = dragon.Health;
                    dragons[type.Color].Dragons[dragon.Name].Damage = dragon.Damage;
                }
                else
                {
                    dragons[type.Color].Dragons.Add(dragon.Name, dragon);
                }
            }

            foreach (var dragon in dragons)
            {
                string type = dragon.Key;

                double averageDamage = dragon.Value.Dragons.Average(x => x.Value.Damage);
                double averageAmor = dragon.Value.Dragons.Average(x => x.Value.Armor);
                double averageHealth = dragon.Value.Dragons.Average(x => x.Value.Health);

                Console.WriteLine($"{type}::({averageDamage:F2}/{averageHealth:F2}/{averageAmor:F2})");

                foreach (var val in dragon.Value.Dragons.OrderBy(x => x.Value.Name)) 
                {
                    Console.WriteLine($"-{val.Value.Name} -> damage: {val.Value.Damage}, health: {val.Value.Health}, armor: {val.Value.Armor}");
                }
            }
        }
    }

    public class Type
    {

        public Type(string color)
        {
            Color = color;
            Dragons = new Dictionary<string, Dragon>();
        }

        public string Color { get; set; }

        public Dictionary<string, Dragon> Dragons { get; set; }
    }

    public class Dragon
    {

        public Dragon(string name, int health, int armor, int damage)
        {
            Name = name;
            Health = health;
            Armor = armor;
            Damage = damage;
        }

        public string Name { get; set; }

        public int Health { get; set; }

        public int Armor { get; set; }

        public int Damage { get; set; }
    }
}