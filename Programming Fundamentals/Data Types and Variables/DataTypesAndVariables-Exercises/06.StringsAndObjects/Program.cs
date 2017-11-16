using System;

namespace _06.StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = "Hello";
            string secondWord = "World";
            object obj = firstWord + " " + secondWord;
            Console.WriteLine(obj);
        }
    }
}
