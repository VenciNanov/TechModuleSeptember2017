using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal number;
            decimal sum=0;

            for (int i = 1; i <= n; i++)
            {
                number = decimal.Parse(Console.ReadLine());
                sum+= number;

            }
            Console.WriteLine(sum);
        }
    }
}
