using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.RoundingAwayFromZero
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums =
                Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            for (int i = 0; i < nums.Length; i++)
            {
                double rounded = (int)Math.Round(nums[i], MidpointRounding.AwayFromZero);



                Console.WriteLine($"{nums[i] }=> {rounded}");
            }
        }
    }
}
