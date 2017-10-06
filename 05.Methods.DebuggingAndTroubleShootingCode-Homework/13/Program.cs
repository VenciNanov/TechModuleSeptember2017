using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(FactorialNumber(n));
           
        }
        static BigInteger FactorialNumber(int num)
        {
            BigInteger factorial = 1;
            int sum = 1;
            for (int i = 1; i <= num; i++)
            {
                
                factorial =factorial*i;
            }
            return factorial;
        }
    }
}
