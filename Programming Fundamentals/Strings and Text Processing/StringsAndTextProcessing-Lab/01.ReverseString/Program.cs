using System;
using System.Linq;

namespace _01.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var reversed = text.Reverse();
            Console.WriteLine(string.Join("",reversed));
        }
    }
}


