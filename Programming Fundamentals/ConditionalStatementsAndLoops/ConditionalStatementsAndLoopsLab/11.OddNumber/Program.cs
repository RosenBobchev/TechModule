using System;

namespace _11.OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            while (number % 2 == 0)
            {
                Console.WriteLine("Please write an odd number.");
                number = int.Parse(Console.ReadLine());
            }
            if (number < 0)
            {
                Console.WriteLine($"The number is: {-number}");
            }
            else
            {
                Console.WriteLine($"The number is: {number}");
            }
        }
    }
}
