namespace _06._Store_Boxes___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] data = input.Split(' ');

                string serialNumber = data[0];
                string itemName = data[1];
                int itemQuantity = int.Parse(data[2]);
                decimal itemPrice = decimal.Parse(data[3]);

                Box box = new Box
                {
                    SerialNumber = serialNumber,
                    Item = new Item()
                    {
                        Name = itemName,
                        Quantity = itemQuantity,
                        Price = itemPrice
                    }
                };

                boxes.Add(box);
            }

            foreach (Box box in boxes.OrderByDescending(b => b.PriceBox))
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.Item.Quantity}");
                Console.WriteLine($"-- ${box.PriceBox:f2}");
            }
        }
    }

    public class Item
    {

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }
    }

    public class Box
    {
        public Box()
        {
            Item = new Item()
        }
        public string SerialNumber { get; set; }

        public Item Item { get; set; }

        public decimal PriceBox
        {
            get
            {
                return this.Item.Price * this.Item.Quantity;
            }
        }
    }
}