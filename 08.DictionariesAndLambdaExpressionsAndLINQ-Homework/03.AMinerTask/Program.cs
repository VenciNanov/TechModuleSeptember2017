using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> sum = new Dictionary<string, long>();
            

            while (true)
            {
                var resource = Console.ReadLine();
             
                if (resource.Equals("stop"))
                {
                    break;
                }

              var  count = long.Parse(Console.ReadLine());

                if (sum.ContainsKey(resource))
                {
                    sum[resource] += count;
                }
                else
                {
                    sum.Add(resource, count);
                }
            }
            
            foreach (var res in sum)
            {
                Console.WriteLine("{0} -> {1}", res.Key, res.Value);
            }
        }
    }
}
