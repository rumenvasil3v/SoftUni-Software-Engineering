using System;

namespace _05._Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Read from the console num of opened tabs.
            int n = int.Parse(Console.ReadLine());
            //2. Read from the console the salary for worker.
            int salary = int.Parse(Console.ReadLine());
            //3. One of these tabs is opened, a fine is charged.
            int facebook = 150; // faceboook 150
            int instagram = 100; // instagram 100
            int reddit = 50; // reddit 50

            //4. Make for loop, which will end when the salary become <= 0
            // as the user has entered for the number of tabs, how long the cycle will be performed
            for (int tab = 1; tab <= n; tab += 1)
            {
                // make variable for the site, which is open
                string website = Console.ReadLine();
                // condition which site is open
                // if its one of the written above, a fine is charged
                if (website == "Facebook") // 150 fine 
                {
                    salary -= facebook;
                }
                else if (website == "Instagram") // 100 fine
                {
                    salary -= instagram;
                }
                else if (website == "Reddit") // 50 fine
                {
                    salary -= reddit;

                }
                // when salary is <= 0
                // loop ends and print => "You have lost your salary."
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }
            // if the salary is > 0 
            // print => salary
            if (salary > 0)
            {
                Console.WriteLine(salary);
            }
        }
    }
}
