using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            List<string> File = new List<string>();

            for (int i = 0; i < n; i++)
            {
                File = Console.ReadLine().Split(';').ToList();
            }

            List<string> extensions = Console.ReadLine().Split(new string[] { " in " }, StringSplitOptions.None).ToList();

            var filePath = extensions[0] + @"\";
            var fileEnd = "." + extensions[1];

            Dictionary<string, string> outputDict = new Dictionary<string, string>();
            foreach (var file in File)
            {
                if (File.ToString().StartsWith(filePath)&&File.ToString().Contains(fileEnd))
                {
                    outputDict.Add(File[1], File[2]);
                }
            }


        }
    }
}
