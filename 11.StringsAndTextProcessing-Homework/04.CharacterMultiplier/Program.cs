using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ');
                
            int minLen = Math.Min(input[0].Length, input[1].Length);
            int maxLen = Math.Max(input[0].Length, input[1].Length);
            int sum = 0;

            for (int i = 0; i < minLen; i++)
            {
                sum += Multiply(input[0][i], input[1][i]);
            }
            if (input[0].Length!=input[1].Length)
            {
                string longerInput = input[0].Length > input[1].Length ? longerInput = input[0] : longerInput = input[1];
                for (int i = minLen ; i < maxLen; i++)
                {
                    sum += longerInput[i];
                }
            }
            Console.WriteLine(sum);
        }
        static int Multiply(char s1, char s2)
        {
            return s1 * s2;
        }
    }
}
