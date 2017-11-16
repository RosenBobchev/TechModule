using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _01.ConvertFromBase_10ToBase_N
{
    class Program
    {
        static void Main(string[] args)
        { 
            BigInteger[] numbers = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();
            BigInteger baseIndex = numbers[0];
            BigInteger num = numbers[1];
            List<BigInteger> digits = new List<BigInteger>();
            while (num != 0)
            {
                BigInteger remainder = num % baseIndex;
                num = num / baseIndex;
                digits.Add(remainder);
            }
            digits.Reverse();
            Console.WriteLine(string.Join("",digits));
        }
    }
}
