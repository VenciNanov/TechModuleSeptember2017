using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Choose_a_drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var count = int.Parse(Console.ReadLine());

            var drink = 0.0;


            switch (input)
            {
                case "Athlete":
                    drink = 0.70 * count;
                    break;
                case "Businessman":
                    drink = 1.00*count;
                    break;
                case "Businesswoman":
                    drink = 1.00 * count;
                    break;
                case "SoftUni Student":
                    drink = 1.70 * count;
                    break;
                default:
                    drink = 1.20 * count;
                    break;

            }
            Console.WriteLine("The {0} has to pay {1:f2}.",input,drink);

        }

    }
}
