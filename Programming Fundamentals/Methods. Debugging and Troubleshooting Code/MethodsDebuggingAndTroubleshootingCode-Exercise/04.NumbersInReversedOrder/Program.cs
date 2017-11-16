using System;

namespace _04.NumbersInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = (Console.ReadLine());
            Console.WriteLine(NumberInReverse(input));
        }
        static string NumberInReverse(string input)
        {
            string output = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                output += input[i];
            }
            return output;
        }
    }
}
