using _06._Store_Boxes;

namespace _06._Store_Boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] arguments = input.Split();

                string serialNumber = arguments[0];
                string itemName = arguments[1];
                int itemQuantity = int.Parse(arguments[2]);
                decimal itemPrice = decimal.Parse(arguments[3]);

                Box box = new Box();
                box.Item = new Item();
                box.Item.Name = itemName;
                box.SerialNumber = serialNumber;
                box.ItemQuantity = itemQuantity;
                box.Item.Price = itemPrice;
                box.PriceForABox = box.Item.Price * box.ItemQuantity;

                boxes.Add(box);
            }

            foreach (Box box in boxes.OrderByDescending(x => x.PriceForABox).ToList())
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForABox:f2}");
            }
        }
    }

    public class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class Box
    {
        public string SerialNumber { get; set; }

        public Item Item { get; set; }

        public int ItemQuantity { get; set; }

        public decimal PriceForABox { get; set; }
    }
}