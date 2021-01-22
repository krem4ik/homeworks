using System;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Here Demo Calculator!\nYou can use operations +-*/");
            float a = 0, b = 0;
            char c;
            Console.WriteLine("Enter first value:");
            if (!float.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Got wrong data!");
                return;
            }
            while (true)
            {
            GETOPERATOR:
                if (!GetOperator(out c))
                {
                    Console.WriteLine("Got wrong data! Enter again!");
                    goto GETOPERATOR;
                }

                Console.WriteLine("Enter next value:");
                if (!float.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Got wrong data!");
                    continue;
                }
                try
                {
                    a = Calculate(a, b, c);
                    Console.WriteLine($"RESULT:{a}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"ERROR:{ex.Message}");
                    continue;
                }
            }

        }

        static bool GetOperator(out char c)
        {
            Console.WriteLine("Enter operator:");
            c = Console.ReadKey().KeyChar;
            switch (c)
            {
                case '+':
                    break;
                case '-':
                    break;
                case '*':
                    break;
                case '/':
                    break;
                default:
                    return false;
            }
            return true;
        }

        static float Calculate(float a, float b, char c)
        {
            switch(c)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '/':
                    if (b == 0)
                        throw new Exception("Can't be divided by zero");
                    return a / b;
            }
            throw new Exception("Got wrong oparator!");
        }
    }
}
