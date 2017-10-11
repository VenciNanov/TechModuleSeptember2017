using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            List<string> command = Console.ReadLine()
                .Split(' ')
                .ToList();

            while (command[0] != "Odd" && command[0] != "Even")
            {
                if (command[0] == "Delete")
                {
                    int number = int.Parse(command[1]);
                    input.RemoveAll(i => i == number);
                }
                else //if (command[0] == "Insert")
                {
                    int element = int.Parse(command[1]);
                    int position = int.Parse(command[2]);

                    input.Insert(position,element);
                }
                command = Console.ReadLine().Split(' ').ToList();
            }
            if (command[0] == "Odd")
            {
                foreach (var odd in input)
                {
                    if (odd % 2 == 1)
                    {
                        Console.Write($"{odd} ");
                    }

                }

            }
            else //if (command[0]=="Even")
            {
                foreach (var even in input)
                {
                    if (even % 2 == 0)
                    {
                        Console.Write($"{even} ");
                    }
                }
            }
            Console.WriteLine();
        }


    }
}

