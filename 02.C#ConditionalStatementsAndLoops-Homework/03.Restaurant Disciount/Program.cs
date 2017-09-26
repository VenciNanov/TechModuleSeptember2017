using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Restaurant_Disciount
{
    class Program
    {
        static void Main(string[] args)
        {
            var groupSize = int.Parse(Console.ReadLine());
            var package = Console.ReadLine();


            double hallPrice = 0.0;

            //HallAndHallPrices

            if (groupSize >= 1 && groupSize <= 50)
            {
                Console.WriteLine("We can offer you the Small Hall");
                hallPrice = 2500;
            }
            else
                if (groupSize > 50 && groupSize <= 100)
            {
                Console.WriteLine("We can offer you the Terrace");
                hallPrice = 5000;
            }
            else
                if (groupSize > 100 && groupSize <= 120)
            {
                Console.WriteLine("We can offer you the Great Hall");
                hallPrice = 7500;
            }
            else
                if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }

            //PackDiscounts
            if (groupSize <120)
            {
                if (package == "Normal")
                {
                    hallPrice += 500;
                    hallPrice = hallPrice * 0.95;
                }
                else
                    if (package == "Gold")
                {
                    hallPrice += 750;
                    hallPrice = hallPrice * 0.90;
                }
                else
                    if (package == "Platinum")
                {
                    hallPrice += 1000;
                    hallPrice = hallPrice * 0.85;
                }
                var pricePerPerson = hallPrice / groupSize;
                Console.WriteLine("The price per person is {0:f2}$", pricePerPerson);
            }
        }
    }
}
