using System;

namespace _04.VariableInHexFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = (Console.ReadLine());

            
            Console.WriteLine(Convert.ToInt32(number, 16));
        }
    }
}
