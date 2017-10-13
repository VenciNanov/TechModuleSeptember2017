using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> book = new Dictionary<string, string>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "stop")
                {
                    break;
                }
                string email = Console.ReadLine();

                //email.Any(c=>char.IsUpper(c))||
                if (email.Contains("uk") || email.Contains("us"))
                {

                }

                book.Add(input, email);



            }
            foreach (var mail in book)
            {
                Console.WriteLine("{0} -> {1}", mail.Key, mail.Value);
            }
        }
    }
}
