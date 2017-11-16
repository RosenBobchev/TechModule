using System;
using System.Numerics;

namespace _03.BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger f = 1;

            for (int i = 2; i <= number; i++)
            {
                f *= i;
            }
            Console.WriteLine(f);
        }
    }
}
