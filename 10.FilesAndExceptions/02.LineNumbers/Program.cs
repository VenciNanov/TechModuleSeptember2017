using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("input.txt");

            var numberLines = lines.Select((line, index) => $"{index + 1}. {line}");
            File.WriteAllLines("output.txt", numberLines);
        }
    }
}
