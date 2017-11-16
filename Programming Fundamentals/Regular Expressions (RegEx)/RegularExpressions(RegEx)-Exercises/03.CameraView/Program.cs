using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03.CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string input = Console.ReadLine();
            string pattern = @"\|<[^\|<]*";

            List<string> result = new List<string>();
            foreach (Match m in Regex.Matches(input, pattern))
            {
                char[] asd = m.Value.Skip(numbers[0] + 2).Take(numbers[1]).ToArray();
                result.Add(string.Join("", asd));
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
