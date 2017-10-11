using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SumAdjecentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> sum = new List<int>();

            int i = 0;
            while (i<input.Count-1)
            {
                if(input[i]==input[i+1])
                {
                    int num = input[i] + input[i + 1];
                    input.Insert(i, num);
                    input.RemoveAt(i + 1);
                    input.RemoveAt(i + 1);
                    i = 0;
                    continue;
                }
                i++;
            }
            Console.WriteLine(string.Join(" ",input));

        }
    }
}
