using System;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 4 numbers:");
            var sequence = new float[4];
            for(var i = 0; i < sequence.Length; i++)
            {
                if (!float.TryParse(Console.ReadLine(), out sequence[i]))
                {
                    Console.WriteLine("Got wrong data! Enter again:");
                    i--;
                    continue;
                }
            }

            float result = 0;

            if (IsSequenceValuesEqual(sequence))
            {
                result = MultiplySequenceValues(sequence);
            } else if (!IsIncreasingSequence(sequence))
            {
                Array.Sort(sequence);
                result = sequence[0];
            } else
            {
                Console.WriteLine("The numbers are arranged in ascending order");
                return;
            }

            Console.WriteLine($"Result:{result}");
        }
        static bool IsIncreasingSequence(float[] sequence )
        {
            if (sequence == null || sequence.Length < 4)
                return false;

            for (var i = 1; i < sequence.Length; i++)
            {
                if (sequence[i - 1] > sequence[i])
                    return false;
            }
            return true;
        }
        static bool IsSequenceValuesEqual(float[] sequence)
        {
            if (sequence == null || sequence.Length < 4)
                return false;
            
            for (var i = 1; i < sequence.Length; i++)
            {
                if (sequence[i - 1] != sequence[i])
                    return false;
            }
            return true;
        }
        static float MultiplySequenceValues(float[] sequence)
        {
            if (sequence == null || sequence.Length < 4)
                return 0;

            for (var i = 1; i < sequence.Length; i++)
            {
                sequence[0] *= sequence[i];
            }
            return sequence[0];
        }
    }
}
