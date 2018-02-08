using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1048
{
    class Program
    {
        static void Main(string[] args)
        {

            float a, b, c;
            a = float.Parse(Console.ReadLine());

            if (a <= 400.0)
            {
                b = (15 * a) / 100;
                c = a + b;
                Console.WriteLine("Novo salario: {0:0.00}", c);
                Console.WriteLine("Reajuste ganho: {0:0.00}", b);
                Console.WriteLine("Em percentual: 15 %");
            }
            else if (a >= 400.01 && a <= 800.00)
            {
                b = (12 * a) / 100;
                c = a + b;
                Console.WriteLine("Novo salario: {0:0.00}", c);
                Console.WriteLine("Reajuste ganho: {0:0.00}", b);
                Console.WriteLine("Em percentual: 12 %");
            }
            else if (a >= 800.01 && a <= 1200.00)
            {
                b = (10 * a) / 100;
                c = a + b;
                Console.WriteLine("Novo salario: {0:0.00}", c);
                Console.WriteLine("Reajuste ganho: {0:0.00}", b);
                Console.WriteLine("Em percentual: 10 %");
            }
            else if (a >= 1200.01 && a <= 2000.00)
            {
                b = (7 * a) / 100;
                c = a + b;
                Console.WriteLine("Novo salario: {0:0.00}", c);
                Console.WriteLine("Reajuste ganho: {0:0.00}", b);
                Console.WriteLine("Em percentual: 7 %");
            }
            else
            {
                b = (4 * a) / 100;
                c = a + b;
                Console.WriteLine("Novo salario: {0:0.00}", c);
                Console.WriteLine("Reajuste ganho: {0:0.00}", b);
                Console.WriteLine("Em percentual: 4 %");
            }

            Console.ReadLine();
        }
    }
}
