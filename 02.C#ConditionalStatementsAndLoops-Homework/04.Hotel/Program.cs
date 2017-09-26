using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());

            var priceStudio = 0.0;
            var priceDouble = 0.0;
            var priceSuite = 0.0;

            if (month == "May" || month == "October")
            {
                priceStudio += 50 * nights;
                priceDouble += 65 * nights;
                priceSuite += 75 * nights;
                if (nights > 7)
                {
                    priceStudio = priceStudio * 0.95;
                    if (month == "October")
                    {
                        var pricePerNight = priceStudio / nights;
                        priceStudio -= pricePerNight;
                    }
                }

            }
            else
                if (month == "June" || month == "September")
            {
                priceStudio += 60 * nights;
                priceDouble += 72 * nights;
                priceSuite += 82 * nights;
                if (nights > 14)
                {
                    priceDouble = priceDouble * 0.90;
                }

                if (month == "September")
                {
                    var pricePerNight = priceStudio / nights;
                    priceStudio -= pricePerNight;
                }
            }


            else
                if (month == "July" || month == "August" || month == "December")
            {
                priceStudio += 68 * nights;
                priceDouble += 77 * nights;
                priceSuite += 89 * nights;
                if (nights > 14)
                {
                    priceSuite = priceSuite * 0.85;
                }
            }

            Console.WriteLine("Studio: {0:f2} lv.", priceStudio);
            Console.WriteLine("Double: {0:f2} lv.", priceDouble);
            Console.WriteLine("Suite: {0:f2} lv.", priceSuite);




        }
    }
}
