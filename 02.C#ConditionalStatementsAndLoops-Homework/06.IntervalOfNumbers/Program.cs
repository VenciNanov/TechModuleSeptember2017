﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                for (int i = n2; i <= n1; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            if(n2>n1)
            {
                for (int i = n1; i <= n2; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
