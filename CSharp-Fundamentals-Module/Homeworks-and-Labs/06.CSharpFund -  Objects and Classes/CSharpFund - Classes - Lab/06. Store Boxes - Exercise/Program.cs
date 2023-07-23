namespace _06._Store_Boxes___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>(); // define collection of boxes 
            string input; // define input
            while ((input = Console.ReadLine()) != "end") // until input != "end"
            {
                string[] data = input.Split(' '); // array of elements from the input

                string serialNumber = data[0]; // first element index[0]
                string itemName = data[1]; // second element index[1]
                int itemQuantity = int.Parse(data[2]); // third element index[2]
                decimal itemPrice = decimal.Parse(data[3]); // fourth element index[3]

                Box box = new Box(serialNumber, itemName, itemQuantity, itemPrice); // define an object[instance] of our data type with constructor
                
                boxes.Add(box); // adding our object to the collection of boxes
            }

            foreach (Box box in boxes.OrderByDescending(b => b.PriceBox)) // print final result so the boxes are ordered descending by PriceBox
            {
                Console.WriteLine(box.SerialNumber); // print box serial number
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price}: {box.Item.Quantity}"); // print name of item - price of item - quantity of item
                Console.WriteLine($"-- ${box.PriceBox}"); // print price for one box
            }
        }
    }

    public class Item // define class Item
    {

        public string Name { get; set; } // prop of type string

        public decimal Price { get; set; } // prop of type decimal

        public int Quantity { get; set; } // prop of type int
    }

    public class Box // define class Box
    {
        public Box(string serialNumber, string itemName, int itemQuantity, decimal itemPrice) // define constructor with 4 params
        {
            Item = new Item(); // define new object of data type Item to our property Item because it is from data type Item

            SerialNumber = serialNumber; // list serial number to our prop
            Item.Name = itemName; // list itemName to our prop
            Item.Quantity = itemQuantity; // list item quantity to our prop
            Item.Price = itemPrice; // list item price to our prop
        }

        public string SerialNumber { get; set; } // prop of type string

        public Item Item { get; set; } // prop of our defined data type Item

        public decimal PriceBox // prop of type decimal which calculates the price for one box with Item.Price prop and Item.Quantity
        {
            get
            {
                return this.Item.Price * this.Item.Quantity; // return the result to our created object of type Box
            }
        }
    }
}