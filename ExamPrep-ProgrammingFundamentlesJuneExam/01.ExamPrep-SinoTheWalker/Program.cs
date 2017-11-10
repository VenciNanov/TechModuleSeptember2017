using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ExamPrep_SinoTheWalker
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeOfLeaving = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
            var steps = int.Parse(Console.ReadLine());
            var secondsPerStep = int.Parse(Console.ReadLine());

            ulong secondsToAdd = (ulong)steps * (ulong)secondsPerStep;
            long initialSeconds = (timeOfLeaving.Hour * 60 * 60) + (timeOfLeaving.Minute * 60) + timeOfLeaving.Second;
            ulong totalSeconds = (ulong)initialSeconds + secondsToAdd;

            var seconds = totalSeconds % 60;
            var totalMinutes = totalSeconds / 60;
            var minutes = totalMinutes % 60;
            var totalHours = totalMinutes / 60;
            var hours = totalHours % 24;

            Console.WriteLine($"Time Arrival: {hours:d2}:{minutes:d2}:{seconds:d2}");


        }
    }
}
