using System;

namespace _07.ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Before:");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");

            int reminder = b;
            b = a;
            Console.WriteLine("After:");
            Console.WriteLine($"a = {reminder}");
            Console.WriteLine($"b = {b}");
        }
    }
}
