using System;

namespace _11._5DifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var startNum = int.Parse(Console.ReadLine());
            var endNum = int.Parse(Console.ReadLine());

            if (endNum - startNum < 5)
            {
                Console.WriteLine("No");
                return;
            }

            for (int i = startNum; i <= endNum - 4; i++)
            {
                for (int j = i + 1; j <= endNum - 3; j++)
                {
                    for (int k = j + 1; k <= endNum - 2; k++)
                    {
                        for (int m = k + 1; m <= endNum - 1; m++)
                        {
                            for (int n = m + 1; n <= endNum; n++)
                            {
                                Console.WriteLine($"{i} {j} {k} {m} {n}");
                            }
                        }
                    }
                }
            }
        }
    }
}
