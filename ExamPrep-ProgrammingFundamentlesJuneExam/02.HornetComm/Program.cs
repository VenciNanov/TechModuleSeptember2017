using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.HornetComm
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> broadcasts = new List<string>();
            List<string> messages = new List<string>();

            var broadcastPattern = @"^(\D+) \<\-\> ([a-zA-Z0-9]+)$";
            var messagePattern = @"(\d+) \<\-\> ([a-zA-Z0-9]+)$";

            Regex messageRegex = new Regex(messagePattern);
            Regex broadcastRegex = new Regex(broadcastPattern);

            string inputLine = Console.ReadLine();

            while (inputLine != "Hornet is Green")
            {
                if (messageRegex.IsMatch(inputLine))
                {
                    Match match = messageRegex.Match(inputLine);
                    var code = string.Join("", match.Groups[1].Value.Reverse());
                    var message = match.Groups[2].Value;
                    messages.Add(code + " -> " + message);
                }
                else if (broadcastRegex.IsMatch(inputLine))
                {

                    Match match = broadcastRegex.Match(inputLine);
                    var code = string.Join("", match.Groups[1].Value);
                    var message = Decrypt(match.Groups[2].Value);
                    broadcasts.Add(message + " -> " + code);
                }
                inputLine = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var broadcast in broadcasts)
                {
                    Console.WriteLine(broadcast);
                }

            }

            Console.WriteLine("Messages:");
            if (messages.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var message in messages)
                {
                    Console.WriteLine(message);

                }
            }

        }
        static string Decrypt(string encryptetFreq)
        {
            string decryptedFreq = "";
            foreach (char c in encryptetFreq)
            {
                if (c>=65&&c<=90)
                {
                    decryptedFreq += (char)(c + 32);
                }
                else if (c>=97 && c<=122)
                {
                    decryptedFreq += (char)(c - 32);
                }
                else
                {
                    decryptedFreq+=c;
                }
            }
            return decryptedFreq;
        }

    }
}
