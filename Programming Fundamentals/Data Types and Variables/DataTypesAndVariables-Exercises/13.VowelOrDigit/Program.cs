using System;

namespace _13.VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());

            if (firstChar == 'a' || firstChar == 'e' || firstChar == 'i' || firstChar == 'o' || firstChar == 'u')
            {
                Console.WriteLine("vowel");
            }
            else if (firstChar == '0' || firstChar == '1' || firstChar == '2' || firstChar == '3' || firstChar == '4' || firstChar == '5' || firstChar == '6' || firstChar == '7' || firstChar == '8' || firstChar == '9')
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
