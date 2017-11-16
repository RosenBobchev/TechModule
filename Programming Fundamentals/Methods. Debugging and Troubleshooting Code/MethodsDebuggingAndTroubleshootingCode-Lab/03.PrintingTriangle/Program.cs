using System;

namespace _03.PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i <= number; i++)
            {
                PrintLine(1, i);
                

            }
            for (int i = number - 1; i >= 0; i--)
            {
                PrintLine(1, i);
            }

        }
        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
