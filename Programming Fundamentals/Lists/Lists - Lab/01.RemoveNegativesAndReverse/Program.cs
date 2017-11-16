using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers =
                Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            numbers.Reverse();
            numbers.RemoveAll(x => x < 0);

            if (numbers.Count <= 0)
            {
                Console.WriteLine("Empty");
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
