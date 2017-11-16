using System;
using System.Text;
using System.Linq;

namespace _06.SumBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine();
            string secondNumber = Console.ReadLine();

            if (firstNumber.Length > secondNumber.Length)
            {
                secondNumber = secondNumber.PadLeft(firstNumber.Length, '0');
            }
            else
            {
                firstNumber = firstNumber.PadLeft(secondNumber.Length, '0');
            }

            StringBuilder sb = new StringBuilder();
            var sum = 0;
            var reminder = 0;
            var number = 0;

            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                sum = firstNumber[i] - 48 + secondNumber[i] - 48 + reminder;
                number = sum % 10;
                sb.Append(number);
                reminder = sum / 10;
                if (i == 0 && reminder > 0)
                {
                    sb.Append(reminder);
                }
            }
            Console.WriteLine(new string(sb.ToString().TrimEnd('0').ToCharArray().Reverse().ToArray()));
        }
    }
}
