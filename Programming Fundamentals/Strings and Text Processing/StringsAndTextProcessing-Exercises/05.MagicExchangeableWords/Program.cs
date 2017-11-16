using System;
using System.Linq;

namespace _05.MagicExchangeableWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();

            string wordOne = input[0];
            string wordTwo = input[1];

            var firstArr = wordOne.ToCharArray().Distinct().ToArray();
            var secondArr = wordTwo.ToCharArray().Distinct().ToArray();

            if (firstArr.Length == secondArr.Length)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
