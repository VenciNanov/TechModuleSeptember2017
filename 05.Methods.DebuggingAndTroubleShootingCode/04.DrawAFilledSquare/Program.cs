using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DrawAFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Header(n);

            Body(n);

            Header(n);
        }
        static void Header(int a)
        {
            Console.WriteLine(new string('-', a * 2));
        }
        static void Body(int b)
        {
            for (int j = 0; j < b - 2; j++)
            {

                Console.Write('-');
                for (int i = 1; i < b; i++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine('-');
            }
        }
    }
}
