using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SoftuniKaraoke
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string[] songs = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();

            var line = Console.ReadLine();

            while (line != "dawn")
            {
                List<string> performance = line.Split(',').Select(p => p.Trim()).ToList();

                var singer = performance[0];
                var song = performance[1];
                var award = performance[2];

                if (participants.Contains(singer)&&songs.Contains(song))
                {
                    if (!result.ContainsKey(singer))
                    {
                        result[singer] = new List<string>();
                    }
                    var awards = result[singer];
                    if (!awards.Contains(award))
                    {
                        awards.Add(award);
                    }
                }
                line = Console.ReadLine();
            }
            if (result.Any())
            {
                foreach (var keyValuePair in result.OrderByDescending(p=>p.Value.Count).ThenBy(n=>n.Key))
                {
                    var singer = keyValuePair.Key;
                    var awards = keyValuePair.Value;
                    Console.WriteLine($"{singer}: {awards.Count} awards");
                    foreach (var award in awards.OrderBy(n=>n))
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No awards");
            }
            


        }
    }
}
