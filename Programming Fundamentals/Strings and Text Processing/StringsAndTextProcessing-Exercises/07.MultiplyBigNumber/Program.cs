﻿using System;
using System.Numerics;

namespace _07.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger num1 = BigInteger.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            var total = num1 * num2;
            Console.WriteLine("{0}", total);
        }
    }
}
