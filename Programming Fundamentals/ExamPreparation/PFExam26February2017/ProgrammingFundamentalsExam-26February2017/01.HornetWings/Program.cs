using System;

namespace _01.HornetWings
{
    class Program
    {
        static void Main(string[] args)
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            double metersTraveled = (wingFlaps / 1000) * distance;
            int timeTraveled = (wingFlaps / endurance) * 5;
            int totalTime = timeTraveled + (wingFlaps / 100);

            Console.WriteLine($"{metersTraveled:F2} m.");
            Console.WriteLine($"{totalTime} s.");
        }
    }
}
