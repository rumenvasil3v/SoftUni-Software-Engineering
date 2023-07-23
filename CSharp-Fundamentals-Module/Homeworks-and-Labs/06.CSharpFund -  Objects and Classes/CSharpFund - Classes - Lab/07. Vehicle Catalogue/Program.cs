using System.Reflection;
/*
Car/Audi/A3/110
Car/Maserati/Levante/350
Truck/Mercedes/Actros/9019
Car/Mercedes/SClass/375
Car/Citroen/Pascal/1090
end

 */
namespace _07._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input; // define input
            Catalogue catalogue = new Catalogue(); // define an object of our data type Catalogue 
            while ((input = Console.ReadLine()) != "end") // until input != "end"
            {
                string[] arguments = input.Split('/', StringSplitOptions.RemoveEmptyEntries); // define an array of elements

                string type = arguments[0]; // first element of index[0]
                string brand = arguments[1]; // second element of index[1]
                string model = arguments[2]; // third element of index[2]

                if (type == "Car") // check if type == "Car"
                {
                    TypeCar(arguments, brand, model, catalogue); // invoke method if it is car
                }
                else if (type == "Truck") // check if type == "Truck"
                {
                    TypeTruck(arguments, brand, model, catalogue); // invoke method if it is truck
                }
            }

            PrintCars(catalogue); // invoke method to print all cars
            PrintTrucks(catalogue); // invoke method to print all trucks
        }

        static void TypeCar(string[] arguments, string brand, string model, Catalogue catalogue)
        {
            int horsePower = int.Parse(arguments[3]); // list argument[3] which is horse power of a car

            Car car = new Car(); // define an object of our data type Car so to add the car to our collection of Catalogue
            car.Brand = brand; // list brand to car prop
            car.Model = model; // list model to car prop
            car.HorsePower = horsePower; // list horse power to car prop

            catalogue.Cars.Add(car); // adding the object to our collection of cars catalogue
        }

        static void TypeTruck(string[] arguments, string brand, string model, Catalogue catalogue)
        {
            int weightOfTruck = int.Parse(arguments[3]); // list arguments[3] which is weight of truck

            Truck truck = new Truck(); // define an object of our data type Truck so to add the truck to our collection of Catalogue
            truck.Brand = brand; // list brand to truck prop
            truck.Model = model; // list model to truck prop
            truck.Weight = weightOfTruck; // list weight to truck prop

            catalogue.Trucks.Add(truck); // adding the truck to our collection of trucks catalogue
        }

        static void PrintCars(Catalogue catalogue)
        {
            if (catalogue.Cars.Count != 0)
            {
                var newList = catalogue.Cars.OrderBy(c => c.Brand).ToList(); // order the catalogue of cars ascending alphabetically by brand
                catalogue.Cars = newList; // list the ordered catalogue to our cars collection of type Catalogue
                Console.WriteLine("Cars:");
                for (int i = 0; i < catalogue.Cars.Count; i++)
                {
                    Console.WriteLine($"{catalogue.Cars[i].Brand}: {catalogue.Cars[i].Model} - {catalogue.Cars[i].HorsePower}hp"); // print information for every car
                }
            }
        }

        static void PrintTrucks(Catalogue catalogue)
        {
            if (catalogue.Trucks.Count != 0)
            {
                var newList = catalogue.Trucks.OrderBy(t => t.Brand).ToList(); // order our truck catalogue ascending alphabetically by brand
                catalogue.Trucks = newList; // list the ordered catalogue to our trucks collection of type Catalogue
                Console.WriteLine("Trucks:");
                for (int i = 0; i < catalogue.Trucks.Count; i++)
                {
                    Console.WriteLine($"{catalogue.Trucks[i].Brand}: {catalogue.Trucks[i].Model} - {catalogue.Trucks[i].Weight}kg"); // print information for every truck
                }
            }
        }
    }

    public class Truck // define class Truck
    {
        public string Brand { get; set; } // prop of type string

        public string Model { get; set; } // prop of type string

        public int Weight { get; set; } // prop of type int
    }

    public class Car // define class Car
    {
        public string Brand { get; set; } // prop of type string

        public string Model { get; set; } // prop of type string

        public int HorsePower { get; set; } // prop of type int
    } 

    public class Catalogue // define class Catalogue
    {
        public Catalogue() // define constructor for our properties so to add objects to our collections of type Car and Truck
        {
            Trucks = new List<Truck>(); // define new collection of Trucks property so to have access to her
            Cars = new List<Car>(); // define new collection of Cars property so to have access to her
        }

        public List<Car> Cars { get; set; } // define prop of type collection List<Car> with our defined type Car

        public List<Truck> Trucks { get; set; } // define prop of type collection List<Truck> with our defined type Truck
    }
}