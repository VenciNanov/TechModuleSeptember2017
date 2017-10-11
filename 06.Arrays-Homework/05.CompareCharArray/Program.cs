using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CompareCharArray
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] line1 = Console.ReadLine()
                .Split(' ')
                .Select(char.Parse)
                .ToArray();
            char[] line2 = Console.ReadLine()
                .Split(' ')
                .Select(char.Parse)
                .ToArray();

            int maxLength = Math.Min(line1.Length, line2.Length);
            bool isFirst = false;


            for (int i = 0; i < maxLength; i++)
            {
                if (line1[i] >= line2[i])
                {
                    isFirst = true;

                }
                else
                {
                    break;
                }

            }
            if (line1.Length >= line2.Length && isFirst)
            {
                Console.WriteLine(string.Join("", line2));
                Console.WriteLine(string.Join("", line1));
            }
            else
            {
                Console.WriteLine(string.Join("", line1));
                Console.WriteLine(string.Join("", line2));
            }
        }
    }
}
