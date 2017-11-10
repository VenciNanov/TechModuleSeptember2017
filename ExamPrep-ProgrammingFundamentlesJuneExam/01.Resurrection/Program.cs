using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Resurrection
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                int bodyLength = int.Parse(Console.ReadLine());
                decimal bodyWidth = decimal.Parse(Console.ReadLine());
                int lengthOfWing = int.Parse(Console.ReadLine());

                decimal totalLength = (decimal)Math.Pow(bodyLength, 2);
                decimal totalWidth = bodyWidth + (2 * lengthOfWing);
                decimal total = totalLength * totalWidth;

                Console.WriteLine(total);

            }
        }
    }
}
