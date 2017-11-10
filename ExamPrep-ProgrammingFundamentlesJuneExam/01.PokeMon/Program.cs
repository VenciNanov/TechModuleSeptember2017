using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            //PokePower
            decimal n = decimal.Parse(Console.ReadLine());
            //Distance between targets
            decimal m = decimal.Parse(Console.ReadLine());
            //ExhaustionFactor
            int y = int.Parse(Console.ReadLine());

            int targetsCount = 0;
            decimal maxN = n;

            while (n >= m)
            {
                n -= m;
                targetsCount++;

                if (n == maxN / 2 && y > 0)
                {
                    n = n / y;
                }

            }
            Console.WriteLine(Math.Floor(n));
            Console.WriteLine(targetsCount);
        }
    }
}
