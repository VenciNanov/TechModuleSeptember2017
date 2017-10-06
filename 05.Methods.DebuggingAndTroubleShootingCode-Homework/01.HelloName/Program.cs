using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Console.WriteLine(Name(name));
        }
        static string Name(string name)
        {
            name = "Hello, " + name + '!';
            return name;
        }
    }
}
