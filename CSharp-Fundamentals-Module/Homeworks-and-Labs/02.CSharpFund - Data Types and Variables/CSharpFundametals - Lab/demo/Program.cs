using System;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(100000000000000.0 + 0.3);

            // 100000000000000 (loss of precision)
            double a = 1.0f, b = 0.33f, sum = 1.33;
            Console.WriteLine("a+b={0} sum={1} equal={2}",a + b, sum, (a + b == sum));
            // a+b = 1.33000001311302 sum=1.33 equal = False

            decimal one = 0m;
            for (int i = 0; i < 10000; i++) one += 0.0001m;
            Console.WriteLine(one); // 0.999999999999906

            double size = 3.14;
            int intSize = (int)size;
            Console.WriteLine(intSize);

            char ch = 'a';
            Console.WriteLine("The code of '{0}' is: {1}", ch, (int)ch);
            ch = 'b';
            Console.WriteLine("The code of '{0}' is: {1}", ch, (int)ch);
            ch = 'A';
            Console.WriteLine("The code of '{0}' is: {1}", ch, (int)ch);
            ch = 'щ'; // Cyrillic letter 'sht'
            Console.WriteLine("The code of '{0}' is: {1}", ch, (int)ch);

            string file = @"C:\Windows\nwin.ini";
            Console.WriteLine(file);

            decimal num1 = 31434997123892398123m;
            Console.WriteLine("This is float data type: {0}", num1);
        }
    }
}
