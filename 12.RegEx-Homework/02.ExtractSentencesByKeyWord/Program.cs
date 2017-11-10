using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.ExtractSentencesByKeyWord
{
    class Program
    {
        private static object regex;

        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var text = Console.ReadLine().Split(new char[] { '!', '.', '?' });

            var pattern = @"\b([word]+)\b";
            var replaced = pattern.Replace("word", word);
            var reg = new Regex(replaced);

            for (int i = 0; i < text.Length; i++)
            {
                var matches = reg.Matches(text[i]);

                foreach (Match match in matches)
                {
                    if (match.Success==true)
                    {
                        Console.WriteLine(text[i].Trim());
                    }
                }
            }



        }
    }
}
