using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());
            var magicNumber = int.Parse(Console.ReadLine());

            var sum = 0;
            var counter = 0;
            var match = 0;



            for (int i = n2; i >= n1; i--)
            {
                for (int j = n2; j >= n1; j--)
                {
                    sum = i + j;
                    counter++;
                    if(sum==magicNumber)
                    {
                        match++;
                        Console.WriteLine("Number found! {0} + {1} = {2}",i,j,magicNumber);
                        return;
                    }
                }

            }
            if (match == 0)
            {
                Console.WriteLine("{0} combinations - neither equals {1}",counter,magicNumber);
            }
            
        }
    }
}
