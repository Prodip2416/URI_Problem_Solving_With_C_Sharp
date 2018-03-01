using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1073
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=2, k;

            k = int.Parse(Console.ReadLine());

            for (i = 2; i <= k; i = i + 2)
            {
                Console.WriteLine("{0}^2 = {1}", i, i * i);
            }

            Console.ReadLine();
        }
    }
}
