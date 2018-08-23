using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1921
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong a = Convert.ToUInt64(Console.ReadLine());

            ulong b = (a*(a - 3))/2;
            Console.WriteLine(b);
        }
    }
}
