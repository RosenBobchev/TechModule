﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ', '.', ',', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

            var list = new List<string>();

            foreach (var word in input)
            {
                if (word.SequenceEqual(word.Reverse()))
                {
                    list.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", list.OrderBy(a => a).Distinct()));
        }
    }
}