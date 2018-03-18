using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1155
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double result = 0;

            for (int i = 1; i <= 100; i++)
            {
                a = (double)1 / i;
                result += a;
            }

            Console.WriteLine("{0:N2}",result);
        }
    }
}
