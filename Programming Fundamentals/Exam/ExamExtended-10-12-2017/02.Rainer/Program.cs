using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Rainer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            int steps = 0;

            int input = sequence[sequence.Count - 1];
            sequence.RemoveAt(sequence.Count - 1);

            List<int> gameField = new List<int>();
            for (int i = 0; i < sequence.Count; i++)
            {
                gameField.Add(sequence[i]);
            }
            

            while (true)
            {
                for (int i = 0; i < sequence.Count; i++)
                {
                    sequence[i] -= 1;
                }
                if (sequence[input] == 0)
                {
                    Console.WriteLine(string.Join(" ", sequence));
                    Console.WriteLine(steps);
                    return;
                }
                for (int i = 0; i < sequence.Count; i++)
                {
                    if (sequence[i] == 0)
                    {
                        sequence[i] = gameField[i];
                    }
                }

                input = int.Parse(Console.ReadLine());
                steps++;
            }
        }
    }
}
