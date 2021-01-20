using System;

namespace Problem_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nEnter the number of seconds:");
            try
            {
                int sec = int.Parse(Console.ReadLine());
                if (sec < 1)
                {
                    Console.WriteLine("Error, got wrong number!");
                    return;
                }
                int result = sec / 60;
                Console.WriteLine($"Result: {result}");
            }
            catch
            {
                Console.WriteLine("Error, got wrong data!");
            }
        }
    }
}
