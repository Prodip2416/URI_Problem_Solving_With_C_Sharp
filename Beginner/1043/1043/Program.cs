using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1043
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x, y, z;
            string[] tokens = Console.ReadLine().Split();
            a = double.Parse(tokens[0]);
            b = double.Parse(tokens[1]);
            c = double.Parse(tokens[2]);

            if (a < b + c && b < a + c && c < a + b)
            {
                x = a + b + c;
                Console.WriteLine("Perimetro = {0:0.0}", x);
            }
            else
            {
                y = a + b;
                z = (y / 2) * c;
                Console.WriteLine("Area = {0:0.0}", z);
            }

            Console.ReadLine();
        }
    }
}
