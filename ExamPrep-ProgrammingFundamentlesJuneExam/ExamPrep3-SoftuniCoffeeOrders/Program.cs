using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep3_SoftuniCoffeeOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            decimal sum = 0;

            for (int i = 0; i < n; i++)
            {
                
                sum += PricePerCoffee();
                
            }

            Console.WriteLine($"Total: ${sum:f2}");
        }
        static decimal PricePerCoffee()
        {
            decimal pricePerCapsule = decimal.Parse(Console.ReadLine());

            DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            int days = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);

            decimal capsules = decimal.Parse(Console.ReadLine());

            var price = (days * capsules) * pricePerCapsule;

            Console.WriteLine($"The price for the coffee is: ${price:f2}");

            return price;
        }

    }
}
