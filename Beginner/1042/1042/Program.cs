using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1042
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            int x=0, y=0, z=0;
            string[] tokens = Console.ReadLine().Split();
            a = int.Parse(tokens[0]);
            b = int.Parse(tokens[1]);
            c = int.Parse(tokens[2]);

            if (a > b && a > c)
            {
                z = a;
                if (b > c)
                {
                    y = b;
                    x = c;
                }
                else
                {
                    y = c;
                    x = b;
                }
            }
            else if (b > a && b > c)
            {
                z = b;
                if (a > c)
                {
                    y = a;
                    x = c;
                }
                else
                {
                    y = c;
                    x = a;
                }
            }

            else if (c > a && c > b)
            {
                z = c;
                if (a > b)
                {
                    y = a;
                    x = b;
                }
                else
                {
                    y = b;
                    x = a;
                }
            }

            Console.WriteLine("{0}\n{1}\n{2}\n", x,y,z);
         
            Console.WriteLine("{0}\n{1}\n{2}", a, b, c);

            Console.ReadLine();
        }
    }
}
