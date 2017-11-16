using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _01.AnonymousDownsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());
            decimal siteLoss = 0;
            BigInteger securityToken = 1;
            List<decimal> totalLoss = new List<decimal>();
            List<string> affectedSites = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] websiteData = Console.ReadLine().Split(' ');
                string siteName = websiteData[0];
                long siteVisits = long.Parse(websiteData[1]);
                decimal pricePerVisit = decimal.Parse(websiteData[2]);

                affectedSites.Add(siteName);
                siteLoss = siteVisits * pricePerVisit;
                totalLoss.Add(siteLoss);

            }
            for (int i = 0; i < n; i++)
            {
                securityToken *= securityKey;
            }
            foreach (var site in affectedSites)
            {
                Console.WriteLine(site);
            }
            Console.WriteLine($"Total Loss: {totalLoss.Sum():F20}");
            Console.WriteLine($"Security Token: {securityToken}");
        }
    }
}
