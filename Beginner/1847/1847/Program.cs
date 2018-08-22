using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1847
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(tokens[0]);
            int b = Convert.ToInt32(tokens[1]);
            int c = Convert.ToInt32(tokens[2]);
            if (a > b)
            {
                if (b > c)
                {
                    if ((b - c) < (a - b)) Console.WriteLine(":)");
                    else Console.WriteLine(":(");
                }
                else Console.WriteLine(":)");
            }
            else if (b > a)
            {
                if (c > b)
                {
                    if ((c - b) < (b - a)) Console.WriteLine(":(");
                    else Console.WriteLine(":)");
                }
                else Console.WriteLine(":(");
            }
            else if (c > b) Console.WriteLine(":)");
            else Console.WriteLine(":(");


        }
    }
}
