using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1118
{
    class Program
    {
        static void Main(string[] args)
        {
            double a=0, b=0, c, g=0, h = 1, x = 1, y = 1;
            for (h = 1; ; h = 1, x = 1, y = 1)
            {
              a = Convert.ToDouble(Console.ReadLine());
                if (a < 0 || a > 10)
                {
                    Console.WriteLine("nota invalida");   
                    continue;
                }
                while (x == 1)
                {
                    b = Convert.ToDouble(Console.ReadLine());
                    if (b < 0 || b > 10)
                    {
                        Console.WriteLine("nota invalida");
                        continue;
                    }
                    x += 2;
                }
                c = (a + b) / 2.0;
                Console.WriteLine("media = {0:N2}",c);
                Console.WriteLine("novo calculo (1-sim 2-nao)");

                while (y == 1)
                {
                    g = Convert.ToDouble(Console.ReadLine());
                    if (g < 1 || g > 2)
                    {
                        Console.WriteLine("novo calculo (1-sim 2-nao)");
                        continue;
                    }
                    y += 2;
                }
                if (g == 2)
                    break;
            }


        }
    }
}
