using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreyAndBilliard
{


    public class Customer
    {
        public String Name { get; set; }
        public Dictionary<string, decimal> Shoplist { get; set; }
        public decimal Bill { get; set; }
        
    }


    public class AndreyAndBilliard
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var sales = new Dictionary<string, decimal>();
            var buyers = new List<Customer>();
            var end = int.Parse(line);
            for (int i = 0; i < end; i++)
            {
                line = Console.ReadLine();
                var input = line.Split('-');
                if (!sales.ContainsKey(input[0]))
                {
                    sales.Add(input[0], decimal.Parse(input[1]));
                }
                sales[input[0]] = decimal.Parse(input[1]);

            }
            while (line != "end of clients")
            {
                line = Console.ReadLine();
                if (line != "end of clients")
                {
                    var input = line.Split("-,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    var customerName = input[0];
                    var desiredProduct = input[1];
                    var quantityProduct = input[2];
                    if (sales.ContainsKey(desiredProduct))
                    {
                        var customer = new Customer();
                        customer.Name = customerName;
                        customer.Shoplist = new Dictionary<string, decimal>();
                        customer.Bill = new decimal();
                        customer.Bill = (decimal)(decimal.Parse(quantityProduct)* sales[desiredProduct]);
                        customer.Shoplist.Add(desiredProduct, int.Parse(quantityProduct));
                        buyers.Add(customer);
                    }
                }
               
            }

           var sorted = buyers.OrderBy(x => x.Name);
            foreach (var buyer in sorted)
            {
                Console.WriteLine(buyer.Name);
                foreach (var item in buyer.Shoplist)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }
                Console.WriteLine($"Bill: {buyer.Bill:f2}");
            }
            var total = 0m;
            foreach (var item in buyers)
            {
                total += item.Bill;
            }
            Console.WriteLine($"Total bill: {total:f2}");


        }
    }
}