using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char[] arr = str.ToCharArray().Reverse().ToArray();
                
            Console.WriteLine(string.Join("",arr));
        }
    }
}
