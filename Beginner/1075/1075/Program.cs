using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1075
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            int i = 2;
            for (i = 2; i < 10000; i += a)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
