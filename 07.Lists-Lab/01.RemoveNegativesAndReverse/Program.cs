using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (input[0] < 0)
            {
                Console.WriteLine("empty");
                break;
            }

            input.RemoveAll(x => x < 0);
            input.Reverse();
            Console.WriteLine(string.Join(" ",input));




        }
    }
}
