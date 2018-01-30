using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;
            int UserInput = int.Parse(Console.ReadLine());

            i = UserInput / 3600;
            j = (UserInput % 3600) / 60;
            k = UserInput % 60;

            Console.WriteLine("{0}:{1}:{2}", i, j, k);
            Console.ReadLine();
        }
    }
}
