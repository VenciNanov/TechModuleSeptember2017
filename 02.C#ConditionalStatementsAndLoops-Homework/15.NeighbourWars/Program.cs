using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            var peshoDMG = int.Parse(Console.ReadLine());
            var goshoDMG = int.Parse(Console.ReadLine());

            var peshoHP = 100;
            var goshoHP = 100;

            var rounds = 0;
            while (true)
            {

                rounds++;
                if (rounds % 2 == 0)
                {
                    peshoHP -= goshoDMG;
                    if (peshoHP <= 0)
                    {
                        break;
                    }
                    Console.WriteLine("Gosho used Thunderous fist and reduced Pesho to {0} health.", peshoHP);
                }

                if (rounds % 2 == 1)
                {
                    goshoHP -= peshoDMG;
                    if (goshoHP <= 0)
                    {
                        break;
                    }
                        Console.WriteLine("Pesho used Roundhouse kick and reduced Gosho to {0} health.", goshoHP);
                }

                if (rounds % 3 == 0)
                {
                    goshoHP += 10;
                    peshoHP += 10;
                }


            }
            if (goshoHP > peshoHP)
            {
                Console.WriteLine("Gosho won in {0}th round.",rounds);
            }
            else
                if (peshoHP > goshoHP)
            {
                Console.WriteLine("Pesho won in {0}th round.",rounds);
            }
        }
    }
}
