using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstLine = Console.ReadLine();
            string secondLine = Console.ReadLine();

            object sentence = firstLine + " " + secondLine;
            string result = (string)sentence;
            Console.WriteLine(result);
        }
    }
}
