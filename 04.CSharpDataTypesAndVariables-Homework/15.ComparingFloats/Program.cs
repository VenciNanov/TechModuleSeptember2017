using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Comparingdoubles
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());

            double difference = Math.Abs(numberOne - numberTwo);

            if (difference > 0.000001)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }
}
