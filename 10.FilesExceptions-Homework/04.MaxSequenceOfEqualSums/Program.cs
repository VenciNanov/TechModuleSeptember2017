using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MaxSequenceOfEqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = File.ReadAllText("input.txt")
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int maxStart = 0;
            int maxLen = 1;
            int currentStart = 0;
            int currentLen = 1;


            for (int i = 1; i <= numbers.Count - 1; i++)
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
            File.Delete("output.txt");
            for (int i = maxStart; i < maxStart + maxLen; i++)
            {
                File.AppendAllText("output.txt", numbers[i].ToString()+" ");
                
            }
            
        }
    }
}
