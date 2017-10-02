using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(GetMultipleOfEvensAndOdds(n));
        }
        static int GetMultipleOfEvensAndOdds(int n)
        {
            int sumEvens = GetSumOfEvenDigits(n);
            int sumOdds = GetSumOfOddDigits(n);
            return sumEvens * sumOdds;
        }
        static int GetSumOfOddDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastdigit = n % 10;
                if (lastdigit % 2 != 0)
                {
                    sum += lastdigit;
                }
                n /= 10;
            }
            return sum;
        }
        static int GetSumOfEvenDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastdigit = n % 10;
                if (lastdigit % 2 == 0)
                {
                    sum += lastdigit;
                }
                n /= 10;
            }
            return sum;

        }
    }
}
