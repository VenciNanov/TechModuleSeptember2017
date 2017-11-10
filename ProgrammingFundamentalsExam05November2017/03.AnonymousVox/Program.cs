using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.AnonymousVox
{
    class Program
    {
        static void Main(string[] args)
        {


            Dictionary<string, Dictionary<string, long>> data = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, long> dataParams = new Dictionary<string, long>();
            while (true)

            {
                string[] input = Console.ReadLine().Split(new string[] { " -> ", " | " }, StringSplitOptions.RemoveEmptyEntries).ToArray();



                if (input[0] == "thetinggoesskrra")
                {
                    break;
                }
                if (input.Length > 1)
                {
                    string dataKey = input[0];
                    int dataSize = int.Parse(input[1]);
                    string dataSet = input[2];
                    if (!data.ContainsKey(dataSet))
                    {
                        data[dataSet] = new Dictionary<string, long>();
                        dataParams.Add(dataKey, dataSize);
                    }
                    else
                    {
                        dataParams.Add(dataKey, dataSize);
                    }
                }
                else
                {
                    string dataSet = input[0];
                    data[dataSet] = new Dictionary<string, long>();
                }

            }
            foreach (var item in data)
            {
                Console.WriteLine(string.Join(" ",data));
            }
        }
    }
}
