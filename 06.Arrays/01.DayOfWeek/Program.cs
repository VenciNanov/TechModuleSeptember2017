﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days =
                {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",
            };

            int dayNum = int.Parse(Console.ReadLine());
            if (dayNum >= 1 && dayNum <= 7)
            {
                Console.WriteLine(days[dayNum - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day");
            }
        }
    }
}
