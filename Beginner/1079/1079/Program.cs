using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1079
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,i=1;
            double a, b, c,d=0;
            n = int.Parse(Console.ReadLine());
           for(i=1;i<=n;i++)
            {
                string[] tokens = Console.ReadLine().Split();
                a = float.Parse(tokens[0]);
                b = float.Parse(tokens[1]);
                c = float.Parse(tokens[2]);
               d = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;
                Console.WriteLine("{0:0.0}", d);
            }
            Console.ReadLine();
        }
    }
}
