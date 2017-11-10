using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _02.ConvertFromBaseNToBase10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Trim().Split();
            int n = int.Parse(nums[0]);
            char[] baseTenNumber = nums[1].ToCharArray();

            BigInteger result = new BigInteger(0);
            

            for (int i = 0; i < baseTenNumber.Length; i++)
            {
                int curr = (int)Char.GetNumericValue(baseTenNumber[i]);
                result += curr * BigInteger.Pow(n, baseTenNumber.Length - i - 1);
            }
            Console.WriteLine(result);


        }
    }
}
