﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CSharpDataTypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());

            long years = centuries * 100;
            long days = (long)(years * 365.2422);
            long hours = days * 24;
            long minutes = hours * 60;
            long seconds = minutes * 60;
           decimal miliseconds = seconds * 1000;
           decimal microsecond = miliseconds * 1000;
            decimal nanoseconds = microsecond * 1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliseconds} milliseconds = {microsecond} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
