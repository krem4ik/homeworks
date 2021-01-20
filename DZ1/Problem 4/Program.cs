using System;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nEnter a two-digit (non-negative) number:");
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number>99 || number < 10)
                {
                    Console.WriteLine("Error, got wrong number!");
                    return;
                }
                int firstDigit = number / 10;
                int secondDigit = number % 10;
                Console.WriteLine($"Result: {secondDigit}{firstDigit}");
            }
            catch
            {
                Console.WriteLine("Error, got wrong data!");
            }
        }
    }
}
