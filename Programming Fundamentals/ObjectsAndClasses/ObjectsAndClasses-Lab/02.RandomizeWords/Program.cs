using System;

namespace _02.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');
            Random randomWords = new Random();

            for (int firstPosition = 0; firstPosition < words.Length; firstPosition++)
            {
                int secondPosition = randomWords.Next(words.Length);
                secondPosition = firstPosition;
            }
            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
