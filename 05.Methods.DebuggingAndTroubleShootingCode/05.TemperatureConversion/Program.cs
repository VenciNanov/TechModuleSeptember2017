using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.TemperatureConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            var fahrenheit = double.Parse(Console.ReadLine());
            var celsius = ConvertingCelsiusToFarenheit(fahrenheit);
            Console.WriteLine("{0:f2}", celsius);
            
        }
        static double ConvertingCelsiusToFarenheit(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
