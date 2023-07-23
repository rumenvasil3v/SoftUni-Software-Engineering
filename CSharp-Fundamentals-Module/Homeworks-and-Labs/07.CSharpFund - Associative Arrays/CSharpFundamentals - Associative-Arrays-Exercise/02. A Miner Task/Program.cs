namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>(); // create an object of Dictionary (collection)

            string input;
            while ((input = Console.ReadLine()) != "stop")
            {
                string usefulFossil = input; // current useful fossil
                int quantity = int.Parse(Console.ReadLine()); // quantity of that useful fossil

                if (!resources.ContainsKey(usefulFossil)) // checks if we have that key in our collection
                {
                    resources.Add(usefulFossil, 0); // if we don't have it we add that key
                }

                resources[usefulFossil] += quantity; // adding quantity of current key (useful fossil)
            }

            PrintResult(resources); // invoke method for final res=ult
        }

        static void PrintResult(Dictionary<string, int> resources)
        {
            foreach (var kvp in resources)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}"); // print result
            }
        }
    }
}