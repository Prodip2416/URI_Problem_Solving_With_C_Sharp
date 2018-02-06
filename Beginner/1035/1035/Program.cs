using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1035
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split();
            int A = int.Parse(tokens[0]);
            int B = int.Parse(tokens[1]);
            int C = int.Parse(tokens[2]);
            int D = int.Parse(tokens[3]);

            if (B > C && D > A && C + D > A + B && C > 0 && D > 0)
            {
               Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
            Console.ReadLine();
        }
    }
}
