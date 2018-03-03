using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1095
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, j=60;

            for (j = 60; j >= 0; j--)
            {
               Console.WriteLine("I={0} J={1}", i, j);
                i += 3;
                j -= 4;
            }
            Console.ReadLine();
        }
    }
}
