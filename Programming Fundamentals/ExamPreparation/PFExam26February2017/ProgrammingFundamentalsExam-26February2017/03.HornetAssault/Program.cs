using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HornetAssault
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] beehives = Console.ReadLine().Split().Select(long.Parse).ToArray();
            List<long> hornets = Console.ReadLine().Split().Select(long.Parse).ToList();

            for (int i = 0; i < beehives.Length; i++)
            {
                long hornetPower = hornets.Sum();
                if (hornetPower <= beehives[i])
                {
                    hornets.RemoveAt(0);
                }
                if (hornetPower > beehives[i])
                {
                    beehives[i] = 0;
                }
                else
                {
                    beehives[i] -= hornetPower;
                }
                if (hornets.Count == 0)
                {
                    break;
                }
            }

            if (beehives.Any(x => x > 0))
            {
                Console.WriteLine(string.Join(" ", beehives.Where(x => x > 0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
