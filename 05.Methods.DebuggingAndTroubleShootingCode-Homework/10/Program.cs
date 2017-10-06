using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            //face Diagonals
            if (input == "face")
            {
                Console.WriteLine($"{FaceDiagonals(n):f2}");
            }
            else if (input == "space")
            {
                Console.WriteLine($"{SpaceDiagonals(n):f2}");
            }
            else if (input == "volume")
            {
                Console.WriteLine($"{Volume(n):f2}");
            }
            else if (input == "area")
            {
                Console.WriteLine($"{Area(n):f2}");
            }
        }
        static double FaceDiagonals(double n)
        {
            return Math.Sqrt(2 * (n * n));

        }
        static double SpaceDiagonals(double n)
        {
            return Math.Sqrt(3 * (n * n));
        }
        static double Volume(double n)
        {
            return Math.Pow(n, 3);
        }
        static double Area(double n)
        {
            return 6 * Math.Pow(n, 2);
        }
    }
}
