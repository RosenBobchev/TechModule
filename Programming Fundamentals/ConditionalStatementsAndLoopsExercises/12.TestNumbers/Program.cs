using System;

namespace _12.TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int boundary = int.Parse(Console.ReadLine());
            int sum = 0;
            int combinations = 0;

            for (int i = number1; i >= 1; i--)
            {
                for (int j = 1; j <= number2; j++)
                {
                    sum += 3 * i * j;
                    combinations++;
                    if (sum >= boundary)
                    {
                        Console.WriteLine($"{combinations} combinations");
                        Console.WriteLine($"Sum: {sum} >= {boundary}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{combinations} combinations");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
