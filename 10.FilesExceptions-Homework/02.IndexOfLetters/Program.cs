using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] alphabet = new string[] {    "a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"
          };
            string input = File.ReadAllText("input.txt");

            File.Delete("output.txt");
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (input[i].ToString().Contains(alphabet[j]))
                    {
                        File.AppendAllText("output.txt", $"{input[i]} -> {j}"+Environment.NewLine);
                        //Console.WriteLine($"{input[i]} -> {j}");
                    }
                }
            }



        }
    }
}
