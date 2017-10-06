using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            if (PointCloserToTheCenter(x1, y1, x2, y2) == true)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }


        }
        static bool PointCloserToTheCenter(double x1, double y1, double x2, double y2)
        {
            x1 = Math.Abs(x1);
            y1 = Math.Abs(y1);
            x2 = Math.Abs(x2);
            y2 = Math.Abs(y2);

            if (x1 <= x2 && y1 <= y2)
            {
                return true;
            }
            else
            {
               return false;
            }
        }
    }
}
