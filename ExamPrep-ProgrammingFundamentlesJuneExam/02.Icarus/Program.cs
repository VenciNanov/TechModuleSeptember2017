using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Icarus
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> plane = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            var position = int.Parse(Console.ReadLine());

            var damage = 1;

            while (true)
            {
                var input = Console.ReadLine().Split(' ').ToArray();

                if (input[0]=="Supernova")
                {
                    break;
                }

                var direction = input[0];
                var steps = int.Parse(input[1]);

                if (direction == "left")
                {
                    for (int i = 1; i <= steps; i++)
                    {
                        if (position <= 0)
                        {
                            damage++;
                            position = plane.Count;
                        }
                        plane[position - 1] -= damage;
                        position--;
                    }
                }
                else if (direction=="right")
                {
                    for (int i = 1; i <= steps; i++)
                    {
                        if (position>=plane.Count-1)
                        {
                            damage++;
                            position = -1;
                        }
                        plane[position + 1] -= damage;
                        position++;
                    }

                }
            }
            Console.WriteLine(string.Join(" ", plane));
        }
    }
}
