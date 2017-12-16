using System;

namespace _10.MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = int.Parse(Console.ReadLine());
            var times = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine($"{numbers} X {times} = {numbers * times}");
                times++;
            } while (times <=10);
        }
    }
}
