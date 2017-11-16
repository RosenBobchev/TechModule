using System;

namespace _15.FastPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int firstNumber = 2; firstNumber <= number; firstNumber++)
            {
                bool inRange = true;
                for (int secondNumber = 2; secondNumber <= Math.Sqrt(firstNumber); secondNumber++)
                {
                    if (firstNumber % secondNumber == 0)
                    {
                        inRange = false;
                        break;
                    }
                }
                Console.WriteLine($"{firstNumber} -> {inRange}");
            }

        }
    }
}
