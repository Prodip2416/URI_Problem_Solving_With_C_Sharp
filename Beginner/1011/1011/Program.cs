using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double R = double.Parse(Console.ReadLine());
            double pie = 3.14159;

            double userResult = R * R * R;

            double FinalResult = (4.0 / 3) * pie * userResult;

            Console.WriteLine("VOLUME = {0:0.000}", FinalResult);
            Console.ReadLine();
        }
    }
}
