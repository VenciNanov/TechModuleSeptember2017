using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Triangle(1, i);
            }

            Triangle(1, n);

            for (int i = n-1; i >= 0; i--)
            {
                Triangle(1, i);
            }
        }
        static void Triangle(int start, int end)
        {

            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
