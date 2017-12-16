using System;
using System.Linq;

namespace _01.Raindrops
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal density = decimal.Parse(Console.ReadLine());
            decimal regionalCoeff = 0M;
            decimal sum = 0M;

            for (int i = 0; i < n; i++)
            {
               
                string[] information = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                long raindropsCount = long.Parse(information[0]);
                long squareMeters = long.Parse(information[1]);

                regionalCoeff = (decimal)raindropsCount / squareMeters;
                sum += regionalCoeff;
            }

            decimal result = 0M;

            try
            {
                result = sum / density;
            }
            catch (Exception)
            {
                result = sum;
            }
            Console.WriteLine($"{result:F3}");
        }
    }
}
