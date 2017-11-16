using System;
using System.Linq;
using System.Collections.Generic;


namespace _01.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] InputNumbers =
                Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            List<int> sequence = new List<int>();

            for (int i = 0; i < InputNumbers.Length; i++)
            {
                int counter = 0;
                for (int j = 0; j <= i; j++)
                {
                    if (InputNumbers[i] == InputNumbers[j])
                    {
                        counter++;
                    }
                }
                sequence.Add(counter);
                
            }
            int maxSequence = sequence.Max();
            int positionMax = sequence.IndexOf(sequence.Max());
            for (int i = 0; i < maxSequence; i++)
            {
                Console.Write(InputNumbers[positionMax]);
                if (i != maxSequence - 1)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
