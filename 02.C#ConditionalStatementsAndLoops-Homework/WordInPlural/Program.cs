using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordInPlural
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            if (word.EndsWith("y"))
            {
                
                Console.WriteLine("{0}ies", word.Remove(word.Length - 1));
            }
            else
            if (word.EndsWith("o")|| word.EndsWith("ch") || word.EndsWith("s") || word.EndsWith("sh") || word.EndsWith("x")|| word.EndsWith("z"))
            {
                Console.WriteLine("{0}es",word);
            }

            else
            {
                Console.WriteLine("{0}s",word);
            }
        }
    }
}
