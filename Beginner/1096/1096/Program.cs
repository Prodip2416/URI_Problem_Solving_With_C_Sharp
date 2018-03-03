using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1096
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;

            for (i = 1; i <= 9; i = i + 2)
            {
                for (j = 7; j >= 5; j--)
                {
                    Console.WriteLine("I={0} J={1}", i, j);
                }
            }

            Console.ReadLine();
        }
    }
}
