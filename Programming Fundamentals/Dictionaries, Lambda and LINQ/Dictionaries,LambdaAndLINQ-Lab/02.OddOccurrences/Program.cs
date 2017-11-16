using System;
using System.Collections.Generic;

namespace _02.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string[] words = input.Split(' ');
            var counts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (counts.ContainsKey(word))
                {
                    counts[word]++;
                }
                else
                {
                    counts[word] = 1;
                }
            }
            var result = new List<string>();
            foreach (var num in counts)
            {
                if (num.Value % 2 != 0)
                {
                    result.Add(num.Key);
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
