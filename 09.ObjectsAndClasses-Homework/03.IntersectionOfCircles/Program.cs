using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.IntersectionOfCircles
{
    public class Circle
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Radius { get; set; }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            string[] circle1Input = Console.ReadLine()
                .Split(' ')
                .ToArray();

            string[] circle2Input = Console.ReadLine()
                .Split(' ')
                .ToArray();

            //Creates first Circle

            Circle firstCircle = new Circle();
            firstCircle.Radius = double.Parse(circle1Input[2]);
            firstCircle.X = double.Parse(circle1Input[0]);
            firstCircle.Y = double.Parse(circle1Input[1]);

            //Creates second Circle

            Circle secondCircle = new Circle();
            secondCircle.Radius = double.Parse(circle2Input[2]);
            secondCircle.X = double.Parse(circle2Input[0]);
            secondCircle.Y = double.Parse(circle2Input[1]);

            bool isIntersect = Intersect(firstCircle, secondCircle);
            if (isIntersect==true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        static public bool Intersect(Circle firstCircle,Circle secondCircle)
        {
            double deltaX = Math.Abs(firstCircle.X - secondCircle.X);
            double deltaY = Math.Abs(firstCircle.Y - secondCircle.Y);
            double distance = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
            double sumRadiuses = firstCircle.Radius + secondCircle.Radius;

            if (sumRadiuses>=distance)
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
