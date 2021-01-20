using System;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter 3 points values. \nGive me variable A:");
                decimal a = decimal.Parse(Console.ReadLine());
                Console.Write("Give me variable B:");
                decimal b = decimal.Parse(Console.ReadLine());
                Console.Write("Give me variable C:");
                decimal c = decimal.Parse(Console.ReadLine());
                var result = (a * b) + (b * c);
                Console.WriteLine($"Result: {result}");
            }
            catch
            {
                Console.WriteLine("Error, got wrong data!");
            }
        }
    }
}
