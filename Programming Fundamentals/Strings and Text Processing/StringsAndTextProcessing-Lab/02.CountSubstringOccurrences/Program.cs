using System;

namespace _02.CountSubstringOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();

            int count = 1;
            int index = input.IndexOf(pattern);
            while (true)
            {
                index = input.IndexOf(pattern, index + 1);
                if (index == -1)
                {
                    break;
                }
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
