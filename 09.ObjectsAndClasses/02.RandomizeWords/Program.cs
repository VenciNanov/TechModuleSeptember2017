using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ')
                .ToArray();

            Random rnd = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                int firstWord = rnd.Next(0, input.Length);
                int secondWord = rnd.Next(0, input.Length);

                string changer = input[firstWord];
                input[firstWord] = input[secondWord];
                input[secondWord] = changer;

                
            }
            Console.WriteLine(string.Join(Environment.NewLine, input));
        }
    }
}
