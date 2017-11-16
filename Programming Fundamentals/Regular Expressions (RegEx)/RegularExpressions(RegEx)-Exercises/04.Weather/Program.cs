using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> citiesWithTemperatures = new Dictionary<string, double>();
            Dictionary<string, string> citiesWithWeather = new Dictionary<string, string>();

            string pattern = @"([A-Z]{2})(\d+\.\d+)([a-zA-Z]+)\|";
            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                if (Regex.IsMatch(inputLine, pattern))
                {
                    Match match = Regex.Match(inputLine, pattern);

                    string city = match.Groups[1].Value;
                    double averageTemperatures = double.Parse(match.Groups[2].Value);
                    string weather = match.Groups[3].Value;

                    citiesWithTemperatures[city] = averageTemperatures;
                    citiesWithWeather[city] = weather;
                }

                inputLine = Console.ReadLine();
            }
            Dictionary<string, double> sortedCitiesAndTemperatures = citiesWithTemperatures
                .OrderBy(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var sortedCity in sortedCitiesAndTemperatures)
            {
                Console.WriteLine($"{sortedCity.Key} => {sortedCity.Value} => {citiesWithWeather[sortedCity.Key]}");
            }
        }
    }
}
