using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();

           var phonebook = new Dictionary<string, string>();
           
           while(command!= "END")
            {
                string[] splitedCommand = command.Split(' ').ToArray();
                if (splitedCommand[0]=="S")
                {
                    if (!phonebook.ContainsKey(splitedCommand[1]))
                    {
                        Console.WriteLine("Contact {0} does not exist.",splitedCommand[1]);
                    }
                    else
                    {
                        Console.WriteLine($"{splitedCommand[1]} -> {phonebook[splitedCommand[1]]}");
                    }
                }
                else
                {
                    phonebook[splitedCommand[1]] = splitedCommand[2];
                }
               
                command = Console.ReadLine();

            }

        }
    }
}
