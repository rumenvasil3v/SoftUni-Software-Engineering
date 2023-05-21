using System;

namespace P05._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double accountBalance = 0;

            string input = Console.ReadLine(); 
            while(input != "NoMoreMoney")
            {
                double depositAmount = double.Parse(input);
                if (depositAmount < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                //Receive depositAmount
                accountBalance+= depositAmount;            
                Console.WriteLine($"Increase: {depositAmount:f2}");
                input= Console.ReadLine();
            }

            if (input == "NoMoreMoney")
            {
                // end command
            }
            Console.WriteLine($"Total: {accountBalance:f2}");
        }
    }
}
