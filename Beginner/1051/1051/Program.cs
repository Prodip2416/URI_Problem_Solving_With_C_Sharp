using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1051
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, d, e, f, g, h;
            a = float.Parse(Console.ReadLine());

            if (a <= 2000.00) Console.WriteLine("Isento");
            else if (a >= 2000.01 && a <= 3000.00)
            {
                b = a - 2000;
                c = (8 * b) / 100;
                Console.WriteLine("R$ {0:0.00}", c);
            }
            else if (a >= 3000.01 && a <= 4500.00)
            {
                b = a - 2000;
                c = b - 1000;
                d = (1000 * 8) / 100;
                e = (c * 18) / 100;
                f = d + e;
                Console.WriteLine("R$ {0:0.00}", f);
            }
            else if (a >= 4500.01)
            {
                b = a - 2000;
                c = b - 1000;
                d = c - 1500;
                e = (1000 * 8) / 100;
                f = (1500 * 18) / 100;
                g = (d * 28) / 100;
                h = g + f + e;
                Console.WriteLine("R$ {0:0.00}", h);
            }

            Console.ReadLine();
        }
    }
}
