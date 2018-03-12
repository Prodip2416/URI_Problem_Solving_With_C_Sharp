using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1142
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
        
            for (int i = 1; i < N; i++)
            {
                for (int j = i; j < N*4; j=j+4)
                {
                    Console.WriteLine("{0} {1} {2} PUM", j, j+1, j+2);
                    i++;
                }
             
            }

        }
    }
}
