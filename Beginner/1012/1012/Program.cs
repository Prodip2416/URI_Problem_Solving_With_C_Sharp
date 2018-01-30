using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1012
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split();
            double A = double.Parse(tokens[0]);
            double B = double.Parse(tokens[1]);
            double C = double.Parse(tokens[2]);

            double pie = 3.14159;

            Console.WriteLine("TRIANGULO: {0:0.000}",((A*C)/2));
            Console.WriteLine("CIRCULO: {0:0.000}",(pie*C*C));
            Console.WriteLine("TRAPEZIO: {0:0.000}",(((A+B)/2)*C));
            Console.WriteLine("QUADRADO: {0:0.000}",(B*B));
            Console.WriteLine("RETANGULO: {0:0.000}",(A*B));

            Console.ReadLine();
        }
    }
}
