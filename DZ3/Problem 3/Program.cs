using System;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("Got wrong data!");
                return;
            }
            var result = "";
            if (a > -1 && a < 15)
                result = "[0-14]";
            if (a > 14 && a < 36)
                result = "[15-35]";
            if (a > 35 && a < 51)
                result = "[35-50]";
            if (a > 49 && a < 100)
                result = "[50-100]";
            if (result.Length == 0)
                result = "Number is smaller then 0 or bigger then 100";
            Console.WriteLine(result);
        }
    }
}
