using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int c = a + b;
            int d = a - b;
            int e = a * b;
            int f = a / b;


            Console.WriteLine("result: " + c);
            Console.WriteLine("result: " + d);
            Console.WriteLine("result: " + e);
            Console.WriteLine("result: " + f);

            Console.WriteLine("Enter a value");
            string g = Console.ReadLine();
            Console.WriteLine("Enter a value");
            string h = Console.ReadLine();

            int num1 = Convert.ToInt32(g);
            int num2 = Convert.ToInt32(h);

            Console.WriteLine("result of {0} and {1} is {2}", g, h, g + h);

            // create object to be able to use method
            Program obj1 = new Program();
            int sum = obj1.GetSum(a, b);
        }

        int GetSum(int value1, int value2)
        {
            return value1 + value2;
        }
    }
}
