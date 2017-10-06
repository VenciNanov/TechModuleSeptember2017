using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _14.FactorialTrailingZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
          
            Console.WriteLine(TrailingZeros(FactorialNumber(n)));

        }
        static BigInteger FactorialNumber(int num)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= num; i++)
            {

                factorial = factorial * i;
            }
            return factorial;
        }
        static int TrailingZeros(BigInteger factorial)
        {
            int zerosCounter = 0;
            string number = factorial.ToString();
            int numbersLength = number.Length;
            for (int i = 1; i <= numbersLength; i++)
            {
                if (number.EndsWith("0"))
                {
                    zerosCounter++;
                    number = number.Remove(number.Length - 1);
                }
                else
                {
                    break;
                }
            }
            return zerosCounter;

        }
    }
}

