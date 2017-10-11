using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int counter = 0;

            for (int i = 0; i < numbers[0]; i++)
            {
                
                if (counter== numbers[1])
                {
                    break;
                }
                else
                {
                    input.RemoveAt(0);
                }
               counter++;
               
            }
            if (input.Contains(numbers[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
            

        }
    }
}
