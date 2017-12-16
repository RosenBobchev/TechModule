using System;
using System.Globalization;

namespace SinoTheWalker
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var leavingSoftUni = DateTime.ParseExact(input, "HH:mm:ss", CultureInfo.InvariantCulture);
            var numberOfSteps = long.Parse(Console.ReadLine()) % 86400;
            var timeForStep = long.Parse(Console.ReadLine()) % 86400;

            long totalTime = numberOfSteps * timeForStep;

            DateTime result = leavingSoftUni.AddSeconds(totalTime);

            Console.WriteLine("Time Arrival: {0:HH:mm:ss}", result);

        }
    }
}
