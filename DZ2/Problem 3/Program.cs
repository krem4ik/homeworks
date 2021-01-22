using System;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 numbers:");
            var numbers = new float[3];
            for (var i = 0; i < numbers.Length; i++)
            {
                if (!float.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.WriteLine("Got wrong data! Enter again:");
                    i--;
                    continue;
                }
            }

            Array.Sort(numbers);
            Console.WriteLine($"Result:{numbers[2]} >= {numbers[1]} >= {numbers[0]}");
        }
    }
}
