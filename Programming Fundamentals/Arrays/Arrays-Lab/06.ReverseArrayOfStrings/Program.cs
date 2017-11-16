using System;

namespace _06.ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] items = input.Split(' ');

            string[] reversed = new string[items.Length];

            for (int i = 0; i < items.Length; i++)
            {
                reversed[items.Length - 1 - i] = items[i];
            }
            Console.WriteLine(String.Join(" ", reversed));
        }
    }
}
