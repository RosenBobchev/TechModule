using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers =
                  Console.ReadLine()
                  .Split('|')
                  .ToList();

            numbers.Reverse();
            List<string> result = new List<string>(numbers);

            for (int i = 0; i < numbers.Count; i++)
            {
                string[] tokens = numbers[i]
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
                result.AddRange(tokens);
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
