using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1564
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                if (n == 0)
                    Console.WriteLine("vai ter copa!");
                else if (n > 0)
                    Console.WriteLine("vai ter duas!");
                else
                    return;
            }
        }
    }
}
