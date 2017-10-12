using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var bomb = nums[0];
            var bombPower = nums[1];

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == bomb)
                {
                    int left = Math.Max(i - bombPower, 0);
                    int right = Math.Min(i + bombPower, input.Count - 1);

                    int bombRange = right - left + 1;

                    input.RemoveRange(left, bombRange);
                    i = 0;
                }
            }





            Console.WriteLine(string.Join(" ", input.Sum()));
        }
    }
}
