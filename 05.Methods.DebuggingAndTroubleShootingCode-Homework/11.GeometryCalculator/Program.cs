using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            if (figure == "triangle")
            {
                var side = double.Parse(Console.ReadLine());
                var height = double.Parse(Console.ReadLine());
                Console.WriteLine($"{TriangleArea(side,height):f2}");
            }
            else if (figure == "square")
            {
                var side = double.Parse(Console.ReadLine());
                Console.WriteLine($"{SquareArea(side):f2}");
            }
            else if (figure == "rectangle")
            {
                var width = double.Parse(Console.ReadLine());
                var height = double.Parse(Console.ReadLine());
                Console.WriteLine($"{RectangleArea(width,height):f2}");
            }
            else if (figure == "circle")
            {
                var radius = double.Parse(Console.ReadLine());
                Console.WriteLine($"{CircleArea(radius):f2}");
            }
        }
        static double TriangleArea(double side, double height)
        {
            return (side * height) / 2;
        }
        static double SquareArea(double side)
        {
            return side * side;
        }
        static double RectangleArea(double width,double height)
        {
            return width * height;
        }
        static double CircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
