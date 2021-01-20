using System;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the coordinates to calculate the distance between them. \nGive me variable X1:");
                double x1 = double.Parse(Console.ReadLine());
                Console.Write("Give me variable Y1:");
                double y1 = double.Parse(Console.ReadLine());
                Console.Write("Give me variable X2:");
                double x2 = double.Parse(Console.ReadLine());
                Console.Write("Give me variable Y2:");
                double y2 = double.Parse(Console.ReadLine());
                var result = Math.Sqrt((x1 - x2) + (y1 - y2));
                Console.WriteLine($"Result: {result}");
            }
            catch
            {
                Console.WriteLine("Error, got wrong data!");
            }
        }
    }
}
