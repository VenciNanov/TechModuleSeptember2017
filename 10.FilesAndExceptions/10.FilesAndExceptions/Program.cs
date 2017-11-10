using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FilesAndExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("lines.txt");
            File.Delete("odd-lines.txt");
            for (int i = 0; i < lines.Length; i +=2)
            {
                File.AppendAllText("odd-lines.txt", lines[i] + Environment.NewLine);
            }
        }
    }
}
