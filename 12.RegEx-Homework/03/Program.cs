using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] camera = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int m = camera[0];
            int t = camera[1];

            string input = Console.ReadLine();

            var pattern = @"\|<\w+";

            var matchedText = Regex.Matches(input, pattern);

            List<string> outputList = new List<string>();

            foreach (Match match in matchedText)
            {
                var res = match.ToString().Skip(m + 2).Take(t);
                outputList.Add(string.Join("",res));
            }
            Console.WriteLine(string.Join(", ",outputList));
            

        }
    }
}
