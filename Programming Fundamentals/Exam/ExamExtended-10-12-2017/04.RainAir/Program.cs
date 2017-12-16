using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.RainAir
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> data = new Dictionary<string, List<int>>();
            string input = string.Empty;
            List<int> flights = new List<int>();

            while ((input = Console.ReadLine()) != "I believe I can fly!")
            {
                var check = input.IndexOf('=');
                if (check == -1)
                {
                    var tokens = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    string customerName = tokens[0];
                    

                    if (!data.ContainsKey(customerName))
                    {
                        data.Add(customerName, new List<int>());
                        for (int i = 1; i < tokens.Length; i++)
                        {
                            data[customerName].Add(int.Parse(tokens[i]));
                        }
                        data[customerName].Sort();
                    }
                    else
                    {
                        for (int i = 1; i < tokens.Length; i++)
                        {
                            data[customerName].Add(int.Parse(tokens[i]));
                        }
                        data[customerName].Sort();
                    }
                }
                else
                {
                    var tokens = input.Split(new string[] { " = " }, StringSplitOptions.RemoveEmptyEntries);
                    string customerName = tokens[0];
                    string secondCustomer = tokens[1];

                    if (data.ContainsKey(customerName) && data.ContainsKey(secondCustomer))
                    {
                         int[] equal = data[secondCustomer].ToArray();
                        data[customerName] = equal.ToList();
                    }
                }
            }

            foreach (var item in data.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine("#{0} ::: {1}", item.Key, string.Join(", ", item.Value));
            }
        }
    }
}
