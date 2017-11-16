using System;
using System.Linq;

namespace _05._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums =
                Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                double rounded = Math.Round(nums[i], 0, MidpointRounding.AwayFromZero);
                Console.WriteLine(nums[i] + " => " + rounded);
            }
        }
    }
}
