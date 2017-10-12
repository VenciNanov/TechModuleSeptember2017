using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ShortWordsorted
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower()
                .Split(' ', '.', ',', ';', ':', '(', ')', '[', ']', '\'', '"', '\\', '/', '!', '?')
                .OrderBy(x => x)
                .Where(num => num.Length < 5)
                .Where(w=>w!="")
                .Distinct()
                .ToArray();
            

            Console.WriteLine(string.Join(", ", input));

        }
    }
}
