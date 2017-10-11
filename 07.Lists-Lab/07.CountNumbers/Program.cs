using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            input.Sort();
            // int[] counter = new int[input.Count];
            int count = 1;
            bool isLastElementPrinted = false;
            for (int i = 1; i < input.Count; i++)
            {
                isLastElementPrinted = true;
                if (input[i] == input[i - 1])
                {
                    count++;
                    if (i == input.Count - 1)
                    {
                        Console.WriteLine("{0} -> {1}", input[i - 1], count);
                    }

                }
                else
                {
                    Console.WriteLine("{0} -> {1}", input[i - 1], count);
                    count = 1;
                }

            }
            if (!isLastElementPrinted)
            {
                Console.WriteLine("{0} -> {1}", input[0], 1);
            }
        }
    }
}