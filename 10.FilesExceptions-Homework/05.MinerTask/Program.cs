using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllLines("input.txt");

            Dictionary<string, long> Mine = new Dictionary<string, long>();

            File.Delete("output.txt");

            for (int i = 0; i < text.Length; i += 2)
            {
                if (text[i] == "stop" || text[i + 1] == "stop")
                {
                    break;
                }
                var resource = text[i];
                var count = long.Parse(text[i + 1]);

                if (Mine.ContainsKey(resource))
                {
                    Mine[resource] += count;
                }
                else
                {
                    Mine.Add(resource, count);
                }
            }
            foreach (var resource in Mine)
            {
                File.AppendAllText("output.txt", $"{resource.Key} -> {resource.Value}" + Environment.NewLine);
            }
        }
    }
}
