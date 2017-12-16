using System;
using System.Linq;

namespace _02.TrophonTheGrumpyCat
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] arr = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();
            long entryPoint = int.Parse(Console.ReadLine());
            string typeOfItems = Console.ReadLine();
            string priceRatings = Console.ReadLine();

            long left = leftSide(arr, entryPoint, typeOfItems, priceRatings);
            long right = rightSide(arr, entryPoint, typeOfItems, priceRatings);

            if (left >= right)
            {
                Console.WriteLine($"Left - {left}");
            }
            else
            {
                Console.WriteLine($"Right - {right}");
            }


        }
        
        private static long rightSide(long[] arr, long entryPoint, string typeOfItems, string priceRatings)
        {
            long sum = 0;
            if (typeOfItems == "cheap")
            {
                for (long i = entryPoint + 1; i < arr.Length; i++)
                {
                    if (arr[i] < arr[entryPoint] && priceRatings == "positive" && arr[i] >= 0)
                    {
                        sum += arr[i];
                    }
                    else if (arr[i] < arr[entryPoint] && priceRatings == "negative" && arr[i] < 0)
                    {
                        sum += arr[i];
                    }
                    else if (arr[i] < arr[entryPoint] && priceRatings == "all")
                    {
                        sum += arr[i];
                    }
                }
            }
            else if (typeOfItems == "expensive")
            {
                for (long i = entryPoint + 1; i < arr.Length; i++)
                {
                    if (arr[i] >= arr[entryPoint] && priceRatings == "positive" && arr[i] >= 0)
                    {
                        sum += arr[i];
                    }
                    else if (arr[i] >= arr[entryPoint] && priceRatings == "negative" && arr[i] < 0)
                    {
                        sum += arr[i];
                    }
                    else if (arr[i] >= arr[entryPoint] && priceRatings == "all")
                    {
                        sum += arr[i];
                    }
                }
            }

            return sum;
        }

        private static long leftSide(long[] arr, long entryPoint, string typeOfItems, string priceRatings)
        {
            long sum = 0;
            if (typeOfItems == "cheap")
            {
                for (long i = entryPoint - 1; i >= 0; i--)
                {
                    if (arr[i] < arr[entryPoint] && priceRatings == "positive" && arr[i] >= 0)
                    {
                        sum += arr[i];
                    }
                    else if (arr[i] < arr[entryPoint] && priceRatings == "negative" && arr[i] < 0)
                    {
                        sum += arr[i];
                    }
                    else if (arr[i] < arr[entryPoint] && priceRatings == "all")
                    {
                        sum += arr[i];
                    }
                }
            }
            else if (typeOfItems == "expensive")
            {
                for (long i = entryPoint - 1; i >= 0; i--)
                {
                    if (arr[i] >= arr[entryPoint] && priceRatings == "positive" && arr[i] >= 0)
                    {
                        sum += arr[i];
                    }
                    else if (arr[i] >= arr[entryPoint] && priceRatings == "negative" && arr[i] < 0)
                    {
                        sum += arr[i];
                    }
                    else if (arr[i] >= arr[entryPoint] && priceRatings == "all")
                    {
                        sum += arr[i];
                    }
                }
            }

            return sum;
        }
    }
}
