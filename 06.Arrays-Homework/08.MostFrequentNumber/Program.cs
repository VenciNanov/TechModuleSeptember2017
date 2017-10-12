using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] counter = new int[65536];
            int current = 0;

            foreach (var num in input)
            {
                counter[num]++;
            }

            int max = counter.Max();
            

            for (int i = 0; i < input.Count; i++)
            {
                if(counter[input[i]]== max)
                {
                    Console.WriteLine(input[i]);
                    return;
                }
            }



        }
    }
}
