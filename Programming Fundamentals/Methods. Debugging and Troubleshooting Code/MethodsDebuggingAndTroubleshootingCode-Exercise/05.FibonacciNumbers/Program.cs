using System;

namespace _05.FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(FibonacciNumber(n));
        }
        static int FibonacciNumber(int n)
        {
            int number = n + 1;
            int[] Fib = new int[number + 1];
            Fib[0] = 0;
            Fib[1] = 1;

            for (int i = 2; i <= number; i++)
            {
                Fib[i] = Fib[i - 2] + Fib[i - 1];
            }
            return Fib[number];
        }
    }
}
