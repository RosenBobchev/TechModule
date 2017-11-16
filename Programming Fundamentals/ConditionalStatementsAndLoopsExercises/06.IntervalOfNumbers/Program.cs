using System;

namespace _06.IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            var smallerNumber = Math.Min(firstNumber, secondNumber);
            var biggerNumber = Math.Max(firstNumber, secondNumber);

            for (int i = smallerNumber; i <= biggerNumber; i++)
            {
                Console.WriteLine(i);
               
            }

        }
    }
}
