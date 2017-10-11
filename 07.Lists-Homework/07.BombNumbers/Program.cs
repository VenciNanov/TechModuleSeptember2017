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
            var bombRange = nums[1];
            
            int counter = 0;

            //for (int i = 0; i < input.Count; i++)
            //{

            //    if (bomb == input[i])
            //    {
            //        input.RemoveRange(input[i],bombRange);
            //        //input.Remove(bomb);



            //    }

            //}
            foreach (var num in input)
            {
                if (num==bomb)
                {
                    input.Remove(bomb);
                }
            }



            Console.WriteLine(string.Join(" ", input));
        }
    }
}
