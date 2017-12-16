using System;

namespace _09.MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var times = 1;
            while (times <= 10)
            {
                Console.WriteLine($"{n} X {times} = {n * times}");
                times++;
            }
        }
    }
}
