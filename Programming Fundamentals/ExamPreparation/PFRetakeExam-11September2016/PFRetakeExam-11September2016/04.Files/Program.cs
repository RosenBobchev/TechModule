using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.Files
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> allFiles = new List<string>();
            for (int i = 0; i < n; i++)
            {
                allFiles.Add(Console.ReadLine());
            }

            string filter = Console.ReadLine();
            var tokens = Regex.Split(filter, " in ");
            var filterExt = "." + tokens[0];
            var filterRoot = tokens[1] + @"\";

            Dictionary<string, long> files = new Dictionary<string, long>();

            foreach (var item in allFiles)
            {
                var filePlusSize = item.Split(';');
                var size = long.Parse(filePlusSize[1]);
                var path = filePlusSize[0];

                if (path.StartsWith(filterRoot) && path.EndsWith(filterExt))
                {
                    var filterTokens = path.Split('\\');
                    var fileName = filterTokens[filterTokens.Length - 1];
                    files[fileName] = size;
                }
            }

            var sortedFiles = files.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

            foreach (var file in sortedFiles)
            {
                Console.WriteLine($"{file.Key} - {file.Value} KB");
            }
            if (sortedFiles.Count() <= 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
