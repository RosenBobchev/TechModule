using System;

namespace _14.FactorialTrailingZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong number = ulong.Parse(Console.ReadLine());
            ulong trailingZeroes = 0;
            ulong lastZeroes = 1;
            ulong powerOfFive = 1;

            while (lastZeroes > 0)
            {
                powerOfFive *= 5;
                lastZeroes = number / powerOfFive;
                trailingZeroes += lastZeroes;
            }
            Console.WriteLine(trailingZeroes);
        }
    }
}
