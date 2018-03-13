using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1149
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int result = 0;
            string[] tokens = Console.ReadLine().Split(' ');
            int A = Convert.ToInt32(tokens[0]);
            int N = Convert.ToInt32(tokens[1]);
            while (N<=0)
            {
                N = Convert.ToInt32(Console.ReadLine());

            }
            


            for (int i = 0; i < N; i++)
            {
                result = result+i + A;
            }
            Console.WriteLine(result);

        }
    }
}
