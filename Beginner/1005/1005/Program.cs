using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double MEDIA = 0;
            double A = Convert.ToDouble(Console.ReadLine());
            double B = Convert.ToDouble(Console.ReadLine());

            MEDIA = ((A*3.5) +( B*7.5)) / (3.5+7.5);

            Console.WriteLine("MEDIA = {0:0.00000}", MEDIA);
            Console.ReadLine();
        }
    }
}
