using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.RefractorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());


            for (int num = 1; num <= length; num++)
            {
                int sum = 0;
                int digit = num;

                while (num > 0)
                {
                    sum += num % 10;
                    num = num / 10;
                }

                bool magic = (num == 5) || (num == 7) || (num == 11);
                Console.WriteLine($"{num} -> {magic}");

            }

        }
    }
}
