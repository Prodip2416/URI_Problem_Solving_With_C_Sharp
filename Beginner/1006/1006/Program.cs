using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1006
{
    class Program
    {
        static void Main(string[] args)
        {
            double MEDIA = 0;
            double A = Convert.ToDouble(Console.ReadLine());
            double B = Convert.ToDouble(Console.ReadLine());
            double C = Convert.ToDouble(Console.ReadLine());

            MEDIA = ((A * 2) + (B * 3)+(C* 5)) / (2+3+5);

            Console.WriteLine("MEDIA = {0:0.0}", MEDIA);
            Console.ReadLine();
        }
    }
}
