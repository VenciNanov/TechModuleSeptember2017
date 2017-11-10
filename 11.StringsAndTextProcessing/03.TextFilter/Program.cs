using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            var badWords = Console.ReadLine().Split(' ', ',').Where(w => w.Length > 0).ToArray() ;
            var text = Console.ReadLine();

            foreach (var badword in badWords)
            {
                var replacement = (new string('*', badword.Length));
                text = text.Replace(badword, replacement);
            }
            Console.WriteLine(text);

        }
    }
}
