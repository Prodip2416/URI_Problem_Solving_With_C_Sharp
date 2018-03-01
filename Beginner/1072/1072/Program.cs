using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1072
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int n = 0, p = 0;
            int a;
            for (int i = 1; i <= x; i++)
            {
                 a = int.Parse(Console.ReadLine());
                if(a>=10 && a <= 20)
                {
                    n++;
                }
                else
                {
                    p++;
                }
            }

            Console.WriteLine("{0} in", n);
            Console.WriteLine("{0} out", p);

            Console.ReadLine();
        }
    }
}
