using System;
using System.Text.RegularExpressions;

namespace _05.MatchNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            var numbersString = Console.ReadLine();
            var numbers = Regex.Matches(numbersString, regex);

            foreach (Match number in numbers)
            {
                Console.Write(number.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
