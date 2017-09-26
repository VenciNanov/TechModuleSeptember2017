using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CakeIngridients
{
    class Program
    {
        static void Main(string[] args)
        {

            var counter = 0;
            for (int i = 1; i <= 20; i++)
            {

                var ingridient = Console.ReadLine();
                if (ingridient == "Bake!")
                {
                    break;
                }
                Console.WriteLine("Adding ingredient {0}.", ingridient);
                counter++;


            }
            Console.WriteLine("Preparing cake with {0} ingredients.", counter);
        }
    }
}
