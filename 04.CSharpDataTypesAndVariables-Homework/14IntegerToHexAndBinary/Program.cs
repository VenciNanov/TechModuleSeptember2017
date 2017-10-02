using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string hexaDecimal = Convert.ToString(input, 16);
            string binary = Convert.ToString(input, 2);


            Console.WriteLine(hexaDecimal.ToUpper());
            Console.WriteLine(binary);

        }
    }
}
