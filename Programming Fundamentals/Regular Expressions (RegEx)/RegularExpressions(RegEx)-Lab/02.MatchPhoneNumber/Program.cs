using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"\+\d{3}(\s|-)\d{1}\1\d{3}\1\d{4}(?!\d)";
            var input = Console.ReadLine();
            var phoneMatches = Regex.Matches(input, pattern);

            var matchedPhones = phoneMatches.Cast<Match>().Select(x => x.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
