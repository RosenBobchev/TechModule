using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _03.MatchHexadecimalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"\b(?:0x)?[0-9A-F]+\b";
            var numbersString = Console.ReadLine();
            var number = Regex.Matches(numbersString, regex).Cast<Match>().Select(x => x.Value).ToArray();

            Console.WriteLine(string.Join(" ", number));
        }
    }
}
