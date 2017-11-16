using System;

namespace _01.CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            long years = centuries * 100;
            long days = (long)(years * 365.2422);
            long hours = days * 24;
            long minutes = hours * 60;

            Console.WriteLine(centuries);
            Console.WriteLine(years);
            Console.WriteLine(days);
            Console.WriteLine(hours);
            Console.WriteLine(minutes);
        }
    }
}
