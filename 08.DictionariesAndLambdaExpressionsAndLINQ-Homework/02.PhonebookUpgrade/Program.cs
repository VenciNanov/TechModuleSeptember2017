using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PhonebookUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();

            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            while (command != "END")
            {
                string[] splitedCommand = command.Split(' ').ToArray();
                if (splitedCommand[0] == "S")
                {
                    if (!phonebook.ContainsKey(splitedCommand[1]))
                    {
                        Console.WriteLine("Contact {0} does not exist.", splitedCommand[1]);
                    }
                    else
                    {
                        Console.WriteLine($"{splitedCommand[1]} -> {phonebook[splitedCommand[1]]}");
                    }
                }
                else if (splitedCommand[0] == "A")
                {
                    phonebook[splitedCommand[1]] = splitedCommand[2];
                }
                else if (splitedCommand[0] == "ListAll")
                {
                    foreach (var phone in phonebook.OrderBy(x=>x.Key))
                    {
                        // Console.WriteLine(string.Join(" ",phonebook.Keys)+" -> "+ string.Join(" ",phonebook.Values));
                        Console.WriteLine(phone.Key +" -> "+ phone.Value);
                    }
                }

                command = Console.ReadLine();

            }
        }
    }
}
