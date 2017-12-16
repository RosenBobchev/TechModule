using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.HornetComm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> messages = new List<string>();
            List<string> broadcasts = new List<string>();
            string messageRegex = @"^([\d]+) <-> ([0-9a-zA-Z]+)$";
            string broadcastRegex = @"^([\D]+) <-> ([0-9a-z-A-Z]+)$";

            Regex message = new Regex(messageRegex);
            Regex broadcast = new Regex(broadcastRegex);

            string input;
            while ((input = Console.ReadLine()) != "Hornet is Green")
            {
                var inputArgs = input.Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);

                if (message.IsMatch(input))
                {
                    messages.Add($"{string.Join("", inputArgs[0].ToCharArray().Reverse())} -> {inputArgs[1]}");
                }

                if (broadcast.IsMatch(input))
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (char ch in inputArgs[1].ToCharArray())
                    {
                        if (char.IsLower(ch))
                        {
                            sb.Append(char.ToUpper(ch));
                            continue;
                        }
                        if (char.IsUpper(ch))
                        {
                            sb.Append(char.ToLower(ch));
                            continue;
                        }

                        sb.Append(ch);
                    }

                    broadcasts.Add($"{sb.ToString()} -> {inputArgs[0]}");
                }
            }

            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count != 0)
            {
                foreach (var currentBroadcast in broadcasts)
                {
                    Console.WriteLine(currentBroadcast);
                }
            }
            else
            {
                Console.WriteLine("None");
            }

            Console.WriteLine("Messages:");
            if (messages.Count != 0)
            {
                foreach (var currentMessage in messages)
                {
                    Console.WriteLine(currentMessage);
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }
    }
}
