using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1116
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            double result = 0;
            for (int i = 0; i < N; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                int X = Convert.ToInt32(tokens[0]);
                int Y = Convert.ToInt32(tokens[1]);

                if (Y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    result = (double)X/Y;
                    Console.WriteLine("{0:N1}",result);
                }
            }
        }
    }
}
