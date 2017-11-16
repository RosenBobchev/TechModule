using System;

namespace _03.EnglishNameOfTheLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            NumberToWord(Math.Abs(number));
        }
        static long NumberToWord(long number)
        {
            number = number % 10;
            if (number == 0)
            {
                Console.WriteLine("zero");
            }
            else if (number == 1)
            {
                Console.WriteLine("one");
            }
            else if (number == 2)
            {
                Console.WriteLine("two");
            }
            else if (number == 3)
            {
                Console.WriteLine("three");
            }
            else if (number == 4)
            {
                Console.WriteLine("four");
            }
            else if (number == 5)
            {
                Console.WriteLine("five");
            }
            else if (number == 6)
            {
                Console.WriteLine("six");
            }
            else if (number == 7)
            {
                Console.WriteLine("seven");
            }
            else if (number == 8)
            {
                Console.WriteLine("eight");
            }
            else if (number == 9)
            {
                Console.WriteLine("nine");
            }
            return number;
        }
    }
}
