using System;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the purchase amount:");
            if (!float.TryParse(Console.ReadLine(), out float amount))
            {
                Console.WriteLine("Wrong data!");
                return;
            }

            int discount = 0;
            if (amount > 500)
            {
                discount = 3;
            }
            if (amount > 1000)
            {
                discount = 5;
            }

            amount -= (amount * discount) / 100;
            Console.WriteLine($"Total purchase price({discount}% discount):{amount}");
        }
    }
}
