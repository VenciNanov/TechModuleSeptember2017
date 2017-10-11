using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AppendList
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var nums = input.Split('|').ToList();

            List<string> results = new List<string>();

            for (int i = nums.Count - 1; i >= 0; i--)
            {
                results.Add(string.Join(" ", nums[i].Split(new char[0], StringSplitOptions.RemoveEmptyEntries)));
            }

            Console.WriteLine(string.Join(" ", results));

        }
    }
}
