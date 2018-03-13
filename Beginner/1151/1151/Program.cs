using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _1151
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int f1 = 0, f2 = 1, f3 = 0;
            int N = Convert.ToInt32(Console.ReadLine());
            Console.Write("0 1 ");
            if (N > 0 && N < 46)
            {
                for (int i = 0; i < N - 2; i++)
                {
                    f3 = f1 + f2;
                    if (i == N - 3)
                    {
                     Console.WriteLine(f3);
                        break;
                    }
                    Console.Write(f3 + " ");
                    f1 = f2;
                    f2 =f3;
                    count++;
                }
               // Console.WriteLine();
            }
        }
    }
}
