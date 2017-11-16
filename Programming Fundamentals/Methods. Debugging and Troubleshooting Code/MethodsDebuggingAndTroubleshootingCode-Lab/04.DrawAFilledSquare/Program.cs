﻿using System;

namespace _04.DrawAFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {


            int n = int.Parse(Console.ReadLine());
            PrintHeaderRow(n);
            PrintMiddleRow(n);
            PrintHeaderRow(n);
        }

             static void PrintMiddleRow(int n)
            {
                for (int i = 0; i < n - 2; i++)
                {
                    Console.Write("-");
                    for (int j = 1; j < n; j++)
                    {
                        Console.Write("\\/");
                    }
                    Console.WriteLine("-");
                }
            }

            static void PrintHeaderRow(int n)
            {
                Console.WriteLine(new string('-', n * 2));
            }

        }
    }

