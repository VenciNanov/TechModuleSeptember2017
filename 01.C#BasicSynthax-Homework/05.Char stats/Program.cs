using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Char_stats
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var hp = int.Parse(Console.ReadLine());
            var maxHp = int.Parse(Console.ReadLine());

            var engergy = int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());

            //name
            Console.WriteLine("Name: {0}",name);
            //HP
            Console.WriteLine("Health: |{0}{1}|",
                new string('|',hp),
                new string ('.',maxHp-hp));
            //ENERGY
            Console.WriteLine("Energy: |{0}{1}|",
                 new string('|', engergy),
                 new string('.', maxEnergy - engergy));
        }
    }
}
