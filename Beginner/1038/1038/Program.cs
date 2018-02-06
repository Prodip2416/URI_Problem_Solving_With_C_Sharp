using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1038
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] tokens = Console.ReadLine().Split();
            double X = double.Parse(tokens[0]);
            double Y = double.Parse(tokens[1]);

            double Z = 0;
            if(X == 1)
            {
                Z = 4.00;  
            }
            else if (X == 2)
            {
                Z = 4.50;
            }
            else if (X == 3)
            {
                Z = 5.00;
            }
            else if (X == 4)
            {
                Z = 2.00;
            }
            else if (X == 5)
            {
                Z = 1.50;
            }

            Console.WriteLine("Total: R$ {0:0.00}", Z * Y);
            Console.ReadLine();
        }
    }
}
