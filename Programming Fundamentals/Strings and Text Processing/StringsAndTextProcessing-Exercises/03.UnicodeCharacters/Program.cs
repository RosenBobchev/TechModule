using System;
using System.Linq;
using System.Text;

namespace _03.UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            foreach (char c in word)
            {
                sb.AppendFormat("\\u{0:x4}", (uint)c);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
