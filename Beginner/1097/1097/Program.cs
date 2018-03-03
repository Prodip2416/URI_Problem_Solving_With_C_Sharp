using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1097
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1, j = 7; i <= 9; i += 2, j += 2)
            {

                for (int l = i, k = j; k >= (j - 2); k--)
                {

                    Console.WriteLine("I=" + l + " J=" + k);
                }
            }
            Console.ReadLine();
        }
    }
}
