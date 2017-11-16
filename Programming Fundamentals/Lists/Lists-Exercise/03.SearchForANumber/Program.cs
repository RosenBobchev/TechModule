using System;
using System.Linq;
using System.Collections.Generic;


namespace _03.SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers;
            int[] arrayOfThreeNumbers;
            ReadingInputOfNumbers(out numbers, out arrayOfThreeNumbers);

            int firstNumber = arrayOfThreeNumbers[0];
            int secondNumber = arrayOfThreeNumbers[1];
            int thirdNumber = arrayOfThreeNumbers[2];

            var saveNewNumber = numbers.Take(firstNumber).ToList();
            saveNewNumber.RemoveRange(0, secondNumber);

            if (saveNewNumber.Contains(thirdNumber))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }

        private static void ReadingInputOfNumbers(out List<int> numbers, out int[] arrayOfThreeNumbers)
        {
            numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            arrayOfThreeNumbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
