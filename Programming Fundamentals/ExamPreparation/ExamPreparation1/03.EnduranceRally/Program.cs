using System;
using System.Linq;

namespace _03.EnduranceRally
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            double[] track = Console.ReadLine().Split().Select(double.Parse).ToArray();
            int[] checkPoints = Console.ReadLine().Split().Select(int.Parse).ToArray();

            foreach (var name in names)
            {
                double fuel = name.First();
                bool madeIt = true;
                for (int i = 0; i < track.Length; i++)
                {
                    if (checkPoints.Contains(i))
                    {
                        fuel += track[i];
                    }
                    else
                    {
                        fuel -= track[i];
                    }
                    if (fuel <= 0)
                    {
                        Console.WriteLine($"{name} - reached {i}");
                        madeIt = false;
                        break;
                    }                           
                }
                if (madeIt)
                {
                    Console.WriteLine($"{name} - fuel left {fuel:F2}");
                }
            }
        }
    }
}
