using System;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A:");
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("Got wrong data!");
                return;
            }

            Console.WriteLine("Enter B:");
            if (!int.TryParse(Console.ReadLine(), out int b))
            {
                Console.WriteLine("Got wrong data!");
                return;
            }

            if (a < b)
                b = a;
            else if (a > b)
                b = a;
            else
            {
                a = 0;
                b = 0;
            }
            Console.WriteLine($"Result A = {a} B = {b}");
        }
    }
}
