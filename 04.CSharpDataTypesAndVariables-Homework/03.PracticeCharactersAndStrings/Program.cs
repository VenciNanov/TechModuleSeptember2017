using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PracticeCharactersAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = Console.ReadLine();
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            char thirdChar = char.Parse(Console.ReadLine());
            string secondString = Console.ReadLine();

            Console.WriteLine(firstString);
            Console.WriteLine(firstChar);
            Console.WriteLine(secondChar);
            Console.WriteLine(thirdChar);
            Console.WriteLine(secondString);
        }
    }
}
