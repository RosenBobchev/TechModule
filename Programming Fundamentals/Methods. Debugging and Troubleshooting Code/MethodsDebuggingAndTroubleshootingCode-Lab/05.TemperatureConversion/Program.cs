using System;

namespace _05.TemperatureConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = double.Parse(Console.ReadLine());
            var celsius = FahrenheitToCelsius(fahrenheit);
            Console.WriteLine("{0:F2}", celsius);
        }
        static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
