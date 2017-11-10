using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.ExtarctEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var pattern = @"(?<=\s|^)([a-z0-9]+(?:[_.-][a-z0-9]+)*@(?:[a-z]+\-?[a-z]+\.)+[a-z]+\-?[a-z]+)\b";

            var textMatches = Regex.Matches(input, pattern);

            foreach (var mail in textMatches)
            {
                Console.WriteLine(mail);
            }

            
        }
    }
}
