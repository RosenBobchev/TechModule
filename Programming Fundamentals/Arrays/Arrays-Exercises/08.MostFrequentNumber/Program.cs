using System;
using System.Linq;

namespace _08.MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort[] arr =
                Console.ReadLine()
                .Split(' ')
                .Select(ushort.Parse)
                .ToArray();
            int[] count = new int[65536];

            foreach (ushort number in arr)
            {
                count[number]++;
            }

            int maxValue = count.Max();
            for (int i = 0; i < arr.Length; i++)
            {
                if (count[arr[i]] == maxValue)
                {
                    Console.WriteLine(arr[i]);
                    return;
                }
            }
        }
    }
}
