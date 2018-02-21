using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1060
{
    class Program
    {
        static void Main(string[] args)
        {
            float  a, i;
            int b=0;
            for (i = 0; i < 6; i++)
            {
                a=float.Parse(Console.ReadLine());
                    if (a > 0)
                    {
                        b++;                    
                    }
            }
            Console.WriteLine("{0} valores positivos",b);
            Console.ReadLine();
        }
    }
}
