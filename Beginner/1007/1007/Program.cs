using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1007
{
    class Program
    {
        static void Main(string[] args)
        {
            int DIFERENCA = 0;
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());

            DIFERENCA = (A * B) - (C * D);
            Console.WriteLine("DIFERENCA = {0}", DIFERENCA);
            Console.ReadLine();
        }
    }
}
