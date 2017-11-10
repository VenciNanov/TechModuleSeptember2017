using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.VOX
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split().ToArray();
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (string word in input)
            {
                var counter = 1; 
                if (!dict.ContainsKey(word))
                {
                    dict.Add(word, counter);

                }
             
            }
        }
    }
}
