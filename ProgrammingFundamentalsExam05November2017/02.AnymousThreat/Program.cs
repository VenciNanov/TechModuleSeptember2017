using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.AnymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            StringBuilder sb = new StringBuilder();

            sb.Append(string.Join(" ", data));

            while (true)
            {
                var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                var command = input[0];

                if (command == "3:1")
                {
                    break;
                }
                var startIndex = int.Parse(input[1]);
                var endIndex = int.Parse(input[2]);

                if (command == "merge")
                {
                    for (int i = startIndex; i < endIndex; i++)
                    {
                        sb.Append(data[i]);
                    }
                }
                if (command == "divide")
                {
                    for (int i = startIndex; i < endIndex; i++)
                    {
                        sb.Append(data[i]);
                    }
                }
            }
            Console.WriteLine(string.Join("", data));
        }


    }
}
