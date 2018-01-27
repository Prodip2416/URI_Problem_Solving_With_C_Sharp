using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double pie = 3.14159;
            double R = Convert.ToDouble(Console.ReadLine());
            double result = pie * R * R;

            Console.WriteLine("A={0:0.0000}", result);
            Console.ReadLine();
        }
    }
}
