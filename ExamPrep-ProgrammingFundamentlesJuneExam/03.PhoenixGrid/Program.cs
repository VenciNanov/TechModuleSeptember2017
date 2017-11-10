using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.PhoenixGrid
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "ReadMe")
                {
                    break;
                }
                Regex pattern = new Regex(@"^([^\s_]{3}\.)+([^\s_]{3})*$");

                if (pattern.IsMatch(input)||input.Length==3)
                {
                    bool isPalindrome = true;

                    for (int i = 0; i < input.Length/2; i++)
                    {
                        if (input[i]!=input[input.Length-1-i])
                        {
                            Console.WriteLine("NO");
                            isPalindrome = false;
                            break;
                        }
                    }
                    if (isPalindrome)
                    {
                        Console.WriteLine("YES");
                    }
                }
                else
                {
                    Console.WriteLine("NO");
                }
                
            }

        }
    }
}
