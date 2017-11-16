using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputKey = Console.ReadLine();
            string inputValueS = Console.ReadLine();
              

            var count = new Dictionary<string, long>();

            while (inputKey != "stop")
            {
                int inputValue = int.Parse(inputValueS);

                if (!count.ContainsKey(inputKey))
                {
                    count.Add(inputKey, 0);
                }
                  count[inputKey] += inputValue;

                inputKey = Console.ReadLine();

                if (inputKey == "stop")
                {
                    foreach (var item in count.Keys)
                    {
                        Console.WriteLine(item + " -> " + count[item]);
                    }
                    return;
                }
                inputValueS = Console.ReadLine();
            }
        }
    }
}

