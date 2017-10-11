using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(new char[] { ',', ';', ':','.','!', '(',')','"','/','\\','[',']',' ','\''}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> lowerCases = new List<string>();
            List<string> mixedCases = new List<string>();
            List<string> upperCases = new List<string>();

            foreach (var word in input)
            {
                for (int i = 0; i < word.Length; i++)
                {

                }

            }

        }
      
    }
}
