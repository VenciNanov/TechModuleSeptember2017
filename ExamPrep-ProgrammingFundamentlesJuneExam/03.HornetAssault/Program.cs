using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.HornetAssault
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] beeHive = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();
            List<long> hornetHive = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();


            for (int i = 0; i < beeHive.Length; i++)
            {
                if (hornetHive.Count <= 0)
                {
                    break;
                }

                long hornetPower = hornetHive.Sum();
                long beehiveCount = beeHive[i];

                beeHive[i] -= hornetPower;
                if (beehiveCount >= hornetPower)
                {
                    hornetHive.RemoveAt(0);
                }

            }

            PrintWinningSide(beeHive,hornetHive);

        }

        private static void PrintWinningSide(long[] beeHives,List<long> hornetHives)
        {
            List<long> aliveBeeHives = new List<long>();

            foreach (var beehive in beeHives)
            {
                if (beehive>0)
                {
                    aliveBeeHives.Add(beehive);
                }
            }
            if (aliveBeeHives.Count > 0)
            {
                Console.WriteLine(string.Join(" ",aliveBeeHives));
            }
            else
            {
                Console.WriteLine(string.Join(" ",hornetHives));
            }
        }
    }
}
