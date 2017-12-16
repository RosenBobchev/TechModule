using System;

namespace _05.ForeignLanguages
{
    class Program
    {
        static void Main(string[] args)
        {
            var country = Console.ReadLine();

            switch (country)
            {
                case "USA":
                case "England": Console.WriteLine("English");
                    break;
                case "Mexico":
                case "Spain":
                case "Argentina":
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
