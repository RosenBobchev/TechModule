using System;
using System.Text.RegularExpressions;

namespace _02.ExtractSentencesByKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();
            string pattern = "\\b" + word + "\\b";
            string[] sentences = text.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            var Regex = new Regex(pattern);

            foreach (var sentence in sentences)
            {
                if (Regex.IsMatch(sentence))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}
