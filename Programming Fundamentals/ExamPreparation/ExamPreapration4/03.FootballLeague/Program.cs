using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> points = new Dictionary<string, int>();
            Dictionary<string, int> goals = new Dictionary<string, int>();
            string key = Console.ReadLine();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "final")
            {
                string[] tokens = input.Split();

                string teamA = ParseTeams(tokens[0], key);
                string teamB = ParseTeams(tokens[1], key);

                string score = tokens[2];
                int scoreTeamA = score.Split(':').Select(int.Parse).First();
                int scoreTeamB = score.Split(':').Select(int.Parse).Last();

                if (!points.ContainsKey(teamA))
                {
                    points[teamA] = 0;
                    goals[teamA] = 0;
                }
                if (!points.ContainsKey(teamB))
                {
                    points[teamB] = 0;
                    goals[teamB] = 0;
                }

                goals[teamA] += scoreTeamA;
                goals[teamB] += scoreTeamB;


                if (scoreTeamA > scoreTeamB)
                {
                    points[teamA] += 3;
                }
                else if (scoreTeamA == scoreTeamB)
                {
                    points[teamA] += 1;
                    points[teamB] += 1;
                }
                else
                {
                    points[teamB] += 3;
                }
                                
            }

            points = points.OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            goals = goals.OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .Take(3)
                .ToDictionary(x => x.Key, x => x.Value);
            int count = 0;
            Console.WriteLine("League standings: ");
            foreach (var team in points)
            {
                Console.WriteLine($"{++count}. {team.Key} {team.Value}");
            }
            Console.WriteLine("Top 3 scored goals: ");
            foreach (var team in goals)
            {
                Console.WriteLine($"- {team.Key} -> {team.Value}");
            }
        }

        private static string ParseTeams(string team, string key)
        {
            int keyLength = key.Length;
            int startIndex = team.IndexOf(key) + keyLength;
            int lastIndex = team.LastIndexOf(key);

            string resultTeam = team.Substring(startIndex, lastIndex - startIndex).ToUpper();
            return new string(resultTeam.Reverse().ToArray());
        }
    }
}
