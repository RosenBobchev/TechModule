using System;
using System.Linq;

namespace _04.TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool isSumEqual = false;

            for (int left = 0; left < nums.Length; left++)
            {
                for (int right = left + 1; right < nums.Length; right++)
                {
                    int sum = nums[left] + nums[right];

                    if (Contains(nums, sum))
                    {
                        Console.WriteLine("{0} + {1} == {2}", nums[left], nums[right], sum);
                        isSumEqual = true;
                    }
                }
            }
            if (!(isSumEqual))
            {
                Console.WriteLine("No");
            }
        }

        private static bool Contains(int[] nums, int element)
        {
            bool exists = false;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == element)
                {
                    exists = true;
                    break;
                }
            }
            return exists;
        }
    }
}
