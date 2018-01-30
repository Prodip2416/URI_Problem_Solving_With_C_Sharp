using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1017
{
    class Program
    {
        static void Main(string[] args)
        {
           double spendTime = double.Parse(Console.ReadLine());
            double avargeSpeed = double.Parse(Console.ReadLine());

            double findLiters = (spendTime * avargeSpeed) / 12;

            Console.WriteLine("{0:0.000}", findLiters);
            Console.ReadLine();
        }
    }
}
