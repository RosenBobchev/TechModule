using System;

namespace _05.BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = (Console.ReadLine());

            Convert.ToBoolean(firstWord);
            if (firstWord == "True")
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
