using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SoftUniKaraoke
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] singers = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            string[] songs = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            string input = Console.ReadLine();
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            while (input != "dawn")
            {
                var tokens = input.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                string singer = tokens[0];
                string song = tokens[1];
                string award = tokens[2];

                if (singers.Contains(singer) && songs.Contains(song))
                {
                    if (!dict.ContainsKey(singer))
                    {
                        dict[singer] = new List<string>();
                    }
                    if (!dict[singer].Contains(award))
                    {
                        dict[singer].Add(award);
                    }
                    
                }

                input = Console.ReadLine();
            }


            if (dict.Count == 0)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                foreach (var person in dict.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{person.Key}: {person.Value.Count} awards");
                    foreach (var award in person.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
        }
    }
}
