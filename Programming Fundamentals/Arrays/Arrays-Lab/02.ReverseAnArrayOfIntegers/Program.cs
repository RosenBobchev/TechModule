using System;

namespace _02.ReverseAnArrayOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] numbers = new int[number];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = number - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
                Console.WriteLine();
            }
            
        }
    }
}
