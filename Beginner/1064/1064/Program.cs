using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1064
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b = 0, c = 0;
            for(int i = 0; i < 6; i++)
            {
                a = float.Parse(Console.ReadLine());
                if (a > 0)
                {
                    c += a;
                    b++;
                }
            }
            Console.WriteLine("{0} valores positivos", (int)b);
            Console.WriteLine("{0:0.0}",c/b);

            Console.ReadLine();
        }
    }
}
