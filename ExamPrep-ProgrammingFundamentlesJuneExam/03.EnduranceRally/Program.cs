using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EnduranceRally
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] drivers = Console.ReadLine().Split(' ').ToArray();
            double[] zones = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int[] checkpoints = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            foreach (var driver in drivers)
            {
                string message = "";
                double fuel = driver[0];
                int checkpointCounter = 0;

                for (int i = 0; i < zones.Length; i++)
                {
                    bool isEqual = false;

                    for (int k = 0; k < checkpoints.Length; k++)
                    {
                        if (i == checkpoints[k])
                        {
                            isEqual = true;
                            break;
                        }
                    }
                    if (isEqual)
                    {
                        fuel += zones[i];
                    }
                    else
                    {
                        fuel -= zones[i];
                    }

                    if (fuel > 0)
                    {
                        checkpointCounter++;
                    }
                    else
                    {
                        message = $"{driver} - reached {checkpointCounter}";
                        Console.WriteLine(message);
                        break;
                    }
                }
                if (fuel > 0)
                {
                    message = $"{driver} - fuel left {fuel:f2}";
                    Console.WriteLine(message);
                }
            }


        }
    }
}
