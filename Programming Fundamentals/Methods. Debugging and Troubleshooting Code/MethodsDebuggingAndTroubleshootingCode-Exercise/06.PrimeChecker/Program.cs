using System;

namespace _06.PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            if (IsPrime(number))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
        static bool IsPrime(long number)
        {
            if (number == 1)
            {
                return false;
            }
            if (number == 2)
            {
                return false;
            }
            if (number % 2 == 0)
            {
                return false;
            }
            int boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
