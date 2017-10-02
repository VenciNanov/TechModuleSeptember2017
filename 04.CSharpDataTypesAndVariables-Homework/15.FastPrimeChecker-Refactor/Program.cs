using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.FastPrimeChecker_Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int j = 2; j <= input; j++)
            {
                bool isTrue = true;
                for (int i = 2; i <= Math.Sqrt(j); i++)
                {
                    if (j % i == 0)
                    {
                        isTrue = false;
                        break;
                    }
                }
                Console.WriteLine($"{j} -> {isTrue}");
            }

        }
    }
}

