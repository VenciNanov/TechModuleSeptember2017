using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.AnonymousDownsite
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var securityKeyInput = int.Parse(Console.ReadLine());

            List<string> SitesAffected = new List<string>();

            decimal sum = 0m;
            

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string site = input[0];
                long siteVisits = long.Parse(input[1]);
                decimal siteCommercialVisit = decimal.Parse(input[2]);

                SitesAffected.Add(site);

                sum += siteVisits * siteCommercialVisit;
                
            }
            foreach (var site in SitesAffected)
            {
                Console.WriteLine(site);
            }
            Console.WriteLine($"Total Loss: {sum:f20}");
            BigInteger securityKey = BigInteger.Pow(securityKeyInput, SitesAffected.Count);

            Console.WriteLine($"Security Token: {securityKey}");
        }
    }
}
