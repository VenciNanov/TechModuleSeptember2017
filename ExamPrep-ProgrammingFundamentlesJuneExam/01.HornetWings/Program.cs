using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HornetWings
{
    class Program
    {
        static void Main(string[] args)
        {
            var wingFlaps = int.Parse(Console.ReadLine());
            double distnacePer1000Flaps = double.Parse(Console.ReadLine());
            var endurance = int.Parse(Console.ReadLine());

            double distnace = (wingFlaps / 1000) * distnacePer1000Flaps;

            double hornetFlapsPerSecond = (wingFlaps / 100);
            double hornetRest = (wingFlaps / endurance) * 5;

            var sum = hornetFlapsPerSecond + hornetRest;

            Console.WriteLine($"{distnace:f2} m.");
            Console.WriteLine($"{sum} s.");

        }
    }
}
