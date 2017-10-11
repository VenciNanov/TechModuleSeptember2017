using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] sum = new int[input.Length];
            int k = int.Parse(Console.ReadLine());

            for (int i = 0; i < k; i++)
            {
                int[] rotated = new int[input.Length];
                rotated[0] = input[input.Length - 1];
                for (int j = 1; j < rotated.Length; j++)
                {
                    rotated[j] = input[j - 1];
                }

                for (int j = 0; j < sum.Length; j++)
                {
                    sum[j] += rotated[j];
                }

                input = rotated;
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
