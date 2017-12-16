using System;

namespace _09.CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numCount = 0;

            while (true)
            {
                try
                {
                    int.Parse(Console.ReadLine());
                    numCount++;
                }
                catch (OverflowException)
                {
                    break;
                }
                catch (FormatException)
                {
                    break;
                }
            }
            Console.WriteLine(numCount);
        }
    }
}
