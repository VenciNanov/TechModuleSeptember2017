using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("input.txt");

            File.Delete("output.txt");

            Dictionary<string, string> sorted = new Dictionary<string, string>();

            for (int i = 0; i < lines.Length; i += 2)
            {
                if (lines[i] == "stop" || lines[i + 1] == "stop")
                {
                    break;
                }
                var name = lines[i];
                var email = lines[i + 1];

                if (!email.EndsWith("uk") && !email.EndsWith("us"))
                {
                    sorted.Add(name, email);
                }
            }
            foreach (var mail in sorted)
            {
                File.AppendAllText("output.txt", $"{mail.Key} -> {mail.Value}" + Environment.NewLine);
            }
        }
    }
}
