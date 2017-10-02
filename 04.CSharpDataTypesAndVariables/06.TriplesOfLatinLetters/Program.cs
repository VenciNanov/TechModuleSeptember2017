using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 0; i <= input - 1; i++)
            {
                for (int j = 0; j <= input - 1; j++)
                {
                    for (int k = 0; k <= input - 1; k++)
                    {
                        char letter1 = (char)('a' + i);
                        char letter2 = (char)('a' + j);
                        char letter3 = (char)('a' + k);
                        Console.WriteLine($"{letter1}{letter2}{letter3}");
                    }
                }
            }

        }
    }
}
