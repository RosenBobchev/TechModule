using System;

namespace _14.IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string hex = Convert.ToString(number, 16).ToUpper();
            string binary = Convert.ToString(number, 2);
            Console.WriteLine(hex);
            Console.WriteLine(binary);
        }
    }
}
