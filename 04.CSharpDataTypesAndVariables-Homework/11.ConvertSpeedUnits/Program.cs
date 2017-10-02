using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            float meters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());
          
            float hoursToSeconds = hours * 3600;
            float minutesToSeconds = minutes * 60;
            float sumSeconds = minutesToSeconds + seconds+hoursToSeconds;
            
            float metersPerSecond = meters / sumSeconds;
            float kilometersPerHour = (float)(metersPerSecond * 3.6);
            float miles = meters / 1609;
            float totalHours = hours + minutes / 60 + seconds / 3600;

            float milesPerHour = miles/totalHours;

          
            Console.WriteLine(metersPerSecond);
            Console.WriteLine(kilometersPerHour);
            Console.WriteLine(milesPerHour);
        }
    }
}
