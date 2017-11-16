using System;

namespace _07.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(RiseToPower(number, power));
            
        }
        static double RiseToPower(double number, int power)
        {
            double result = 1;
            for (int i = 1; i <= power; i++)
            {
                result = result * number;

            }
            return result;
            
        }
        
    }
}
