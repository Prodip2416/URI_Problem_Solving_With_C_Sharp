using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1866
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int b = Convert.ToInt32(Console.ReadLine());

                if (b % 2 == 0)
                    Console.WriteLine("0");
                else
                {
                    Console.WriteLine("1");
                }
            }
        }
    }
}
