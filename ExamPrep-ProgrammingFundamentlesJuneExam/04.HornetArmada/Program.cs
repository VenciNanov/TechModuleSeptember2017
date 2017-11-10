using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.HornetArmada
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Dictionary<string, int> armada = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(':').ToArray();

                armada.Add(input[0], int.Parse(input[1]));
            }
            var outputComm = Console.ReadLine();



        }
    }
}
