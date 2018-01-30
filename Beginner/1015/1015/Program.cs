using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1015
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split();

            double x1 = double.Parse(tokens[0]);
            double y1 = double.Parse(tokens[1]);

            string[] tokens1 = Console.ReadLine().Split();
            double x2 = double.Parse(tokens1[0]);
            double y2 = double.Parse(tokens1[1]);

            double firstValue = ((x2 - x1)*(x2-x1));
            double secondValue = ((y2 - y1)*(y2-y1));

           double Distance = firstValue + secondValue;
            double FinalResult = Math.Sqrt(Distance);

            Console.WriteLine("{0:0.0000}",FinalResult);

            Console.ReadLine();
        }
    }
}
