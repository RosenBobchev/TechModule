using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _05.KeyReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string text = Console.ReadLine();
            string pattern = @"^(?<startKey>[a-zA-Z]*)(?:\<|\||\\)(?:.+)(?:\<|\||\\)(?<endKey>[a-zA-Z]*)$";

            var keyMatch = Regex.Match(key, pattern);

            if (keyMatch.Success)
            {
                var startKey = keyMatch.Groups["startKey"].Value;
                var endKey = keyMatch.Groups["endKey"].Value;
                var textPattern = $@"{startKey}(?<word>.*?){endKey}";
                var matches = Regex.Matches(text, textPattern);

                var result = new StringBuilder();

                foreach (Match match in matches)
                {
                    result.Append(match.Groups["word"].Value);
                }

                Console.WriteLine(result.ToString().Length == 0 ? "Empty result" : result.ToString());
            }
        }
    }
}
