using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());
            var maxSum = int.Parse(Console.ReadLine());

            var sum1 = 0;
            var count = 0;
            for (int i = n1; i > 0; --i)
            {
                for (int j = 1; j <= n2; j++)
                {
                   
                    if (sum1 >= maxSum)
                    {
                        break;
                    }
                    sum1 = sum1 + (3 * (i * j));
                    count++;
                }
            }
            if (sum1 >= maxSum)
            {
                Console.WriteLine("{0} combinations",count);
                Console.WriteLine("Sum: {0} >= {1}",sum1,maxSum);
            }
            else
                if (sum1 < maxSum)
            {
                Console.WriteLine("{0} combinations", count);
                Console.WriteLine("Sum: {0}",sum1);
            }
        }
    }
}
