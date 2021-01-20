using System;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me 2 non-negative numbers. \nEnter first number:");
            try
            {
                int a = int.Parse(Console.ReadLine());
                Console.Write("Enter second number:");
                int b = int.Parse(Console.ReadLine());
                var result = Math.Sqrt(a * b);
                Console.WriteLine($"Result: {result}");
            }
            catch
            {
                Console.WriteLine("Error, got wrong data!");
            }
        }
    }
}
