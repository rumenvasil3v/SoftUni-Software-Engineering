namespace _04._Raw_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int n = 0; n < numberOfCars; n++)
            {
                string[] carData = Console.ReadLine().Split();

                string carModel = carData[0];
                int engineSpeed = int.Parse(carData[1]);
                int enginePower = int.Parse(carData[2]);
                int cargoWeight = int.Parse(carData[3]);
                string cargoType = carData[4];

                Car car = new Car(carModel, engineSpeed, enginePower, cargoWeight, cargoType);

                cars.Add(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                PrintAllCarsWhichCargoIsFragile(cars);
            }
            else if (command == "flamable")
            {
                PrintAllCarsWhichCargoIsFlamable(cars);
            }
        }

        static void PrintAllCarsWhichCargoIsFragile(List<Car> cars)
        {
            for (int n = 0; n < cars.Count; n++) 
            {
                if (cars[n].Cargo.Weight < 1000)
                {
                    Console.WriteLine("{0}", cars[n].Model);
                }
            }
        }

        static void PrintAllCarsWhichCargoIsFlamable(List<Car> cars)
        {
            for (int n = 0; n < cars.Count; n++)
            {
                if (cars[n].Engine.Power > 250)
                {
                    Console.WriteLine("{0}", cars[n].Model);
                }
            }
        }
    }

    public class Car
    {

        public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType)
        {
            Model = model;
            this.Engine = new Engine(engineSpeed, enginePower);
            this.Cargo = new Cargo(cargoWeight, cargoType);
        }

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public Cargo Cargo { get; set; }
    }

    public class Engine
    {

        public Engine(int speed, int power)
        {
            this.Speed = speed;
            this.Power = power;
        }

        public int Speed { get; set; }

        public int Power { get; set; }

    }

    public class Cargo
    {

        public Cargo(int weight, string type)
        {
            this.Weight = weight;
            this.Type = type;
        }

        public int Weight { get; set; }

        public string Type { get; set; }
    }
}