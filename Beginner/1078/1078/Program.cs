using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1078
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i=1;
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", i, n, i * n);
            }
            Console.ReadLine();
        }
    }
}
