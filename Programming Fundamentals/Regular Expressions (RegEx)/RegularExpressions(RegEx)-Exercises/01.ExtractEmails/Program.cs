using System;
using System.Text.RegularExpressions;

namespace _01.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"(\s[a-zA-Z0-9][\w\.-]*\@[a-zA-Z-]+)(\.[a-zA-Z]+)+";
            MatchCollection matchedNames = Regex.Matches(text, pattern);

            foreach (Match emailMatch in matchedNames)
            {
                Console.WriteLine(emailMatch);
            }
        }
    }
}

