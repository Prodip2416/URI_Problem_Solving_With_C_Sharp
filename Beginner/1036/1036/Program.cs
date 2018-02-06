using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1036
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, b, c, r1, r2, del;

            string[] tokens = Console.ReadLine().Split();
            a = double.Parse(tokens[0]);
            b = double.Parse(tokens[1]);
            c = double.Parse(tokens[2]);

            del = (b * b) - (4 * a * c);

            r1 = (-b + Math.Sqrt(del)) / (2 * a);

            r2 = (-b - Math.Sqrt(del)) / (2 * a);

            if (a != 0 && del > 0)

            {

                Console.WriteLine("R1 = {0:0.00000}", r1);
                Console.WriteLine("R2 = {0:0.00000}", r2);

            }

            else
            {
                Console.WriteLine("Impossivel calcular");
            }
            Console.ReadLine();
        }
    }
}
