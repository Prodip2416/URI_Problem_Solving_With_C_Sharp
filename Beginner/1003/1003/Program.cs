using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1003
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            int SOMA = 0;
            SOMA = A + B;

            Console.WriteLine("SOMA = {0}",SOMA);
            Console.ReadLine();
        }
    }
}
