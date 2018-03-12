using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1144
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("{0} {1} {2}",i,i*i,i*i*i);
                Console.WriteLine("{0} {1} {2}", i, (i * i)+1, (i * i * i)+1);
            }
        }
    }
}
