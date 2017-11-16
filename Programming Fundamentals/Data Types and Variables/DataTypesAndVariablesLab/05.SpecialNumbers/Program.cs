using System;

namespace _05.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int n = 1; n <= number; n++)
            {
                int sumOfDigits = 0;
                int digits = n;
                while (digits > 0)
                {
                    sumOfDigits += digits % 10;
                    digits = digits / 10;
                }
                bool special = false;
                if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
                {
                    special = true;
                }
                Console.WriteLine($"{n} -> {special}");
            }
            
        }
    }
}
