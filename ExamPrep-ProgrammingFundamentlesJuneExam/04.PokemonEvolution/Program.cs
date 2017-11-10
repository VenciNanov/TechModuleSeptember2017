using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PokemonEvolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pokemons = new Dictionary<string, List<string>>();

            while (input!= "wubbalubbadubdub")
            {
                var tokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string pokeName = tokens[0];
                if (tokens.Length>1)
                {
                    string evoType = tokens[1];
                    int points = int.Parse(tokens[2]);
                    if (!pokemons.ContainsKey(pokeName))
                    {
                        pokemons[pokeName] = new List<string>();
                    }
                    var pointsEvoType = evoType + " <-> " + points;
                    pokemons[pokeName].Add(pointsEvoType);

                }
                else
                {
                    if (pokemons.ContainsKey(pokeName))
                    {
                        Console.WriteLine("# "+ pokeName);
                        foreach (var evo in pokemons[pokeName])
                        {
                            Console.WriteLine(evo);
                        }
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var item in pokemons)
            {
                string name = item.Key;
                Console.WriteLine("# "+name);
                foreach (var typeAndNumber in item.Value.OrderByDescending(x=>int.Parse(x.Split(new string[] { " <-> " },StringSplitOptions.None).Skip(1).First())))
                {
                    Console.WriteLine(typeAndNumber);
                }
            }
        }
    }
}
