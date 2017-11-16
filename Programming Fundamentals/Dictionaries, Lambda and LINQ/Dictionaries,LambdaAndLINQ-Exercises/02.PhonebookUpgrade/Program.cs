﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.PhonebookUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();
            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] phonebookParameters = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string command = phonebookParameters[0];

                if (command == "A")
                {
                    string key = phonebookParameters[1];
                    string value = phonebookParameters[2];
                    phonebook[key] = value;
                }
                else if (command == "S")
                {
                    string key = phonebookParameters[1];
                    if (phonebook.ContainsKey(key))
                    {
                        Console.WriteLine($"{key} -> {phonebook[key]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {key} does not exist.");
                    }
                }
                else if (command == "ListAll")
                {
                    foreach (var item in phonebook.Keys)
                    {
                        phonebook.OrderBy(x => x);
                        Console.WriteLine(item + " -> " + phonebook[item]);
                    }
                }
                input = Console.ReadLine();
            }
        }
    }
}
