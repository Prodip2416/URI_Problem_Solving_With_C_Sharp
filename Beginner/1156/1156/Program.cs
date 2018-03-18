using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1156
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, b = 1, c, S = 0;
            for (a = 1; a <= 39; a += 2)
            {
                c = a / b;
                S += c;
                b *= 2;
            }
            Console.WriteLine("{0:N2}",S);
           
        }
    }
}
