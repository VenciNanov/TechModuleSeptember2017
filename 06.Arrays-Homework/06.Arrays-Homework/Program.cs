using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Arrays_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            string[] line1 = input1.Split(' ');
            string[] line2 = input2.Split(' ');

            var minLength = Math.Min(line1.Length, line2.Length);
            var leftSeqLen = 0;
            for (int i = 0; i < minLength; i++)
            {
                if (line1[i] != line2[i])
                {
                    break;
                }

                leftSeqLen++;
            }

            line1 = line1.Reverse().ToArray();
            line2 = line2.Reverse().ToArray();
            int rightSeqLen = 0;
            for (int i = 0; i < minLength; i++)
            {
                if (line1[i] != line2[i])
                {
                    break;
                }

                rightSeqLen++;
            }

            Console.WriteLine(Math.Max(leftSeqLen, rightSeqLen));

        }
    }
}
