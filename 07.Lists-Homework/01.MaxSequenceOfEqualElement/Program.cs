using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MaxSequenceOfEqualElement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int maxStart = 0;
            int maxLen = 1;
            int currentStart = 0;
            int currentLen = 1;


            for (int i = 1; i <= numbers.Count-1; i++)
            {
                if (numbers[i] == numbers[currentStart])
                {
                    currentLen++;
                    if (currentLen > maxLen)
                    {
                        maxLen = currentLen;
                        maxStart = currentStart;
                    }
                }
                else
                {
                    currentLen = 1;
                    currentStart = i;
                }
            }
            for (int i = maxStart; i < maxStart+maxLen; i++)
            {
                Console.Write("{0} ",numbers[i]);

            }
            Console.WriteLine();
        }
    }
}
