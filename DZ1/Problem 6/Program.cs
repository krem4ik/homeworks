using System;

namespace Problem_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nEnter the day of year:");
            try
            {
                int day = int.Parse(Console.ReadLine());
                if (day < 0 || day > 365)
                {
                    Console.WriteLine("Error, got wrong day!");
                    return;
                }
                int result = day % 7;
                Console.WriteLine($"Result: {(DayOfWeek)Enum.ToObject(typeof(DayOfWeek) , result)}");
            }
            catch
            {
                Console.WriteLine("Error, got wrong data!");
            }
        }
    }
}
