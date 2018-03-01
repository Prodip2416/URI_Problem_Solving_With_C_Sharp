using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1074
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n;
            j = int.Parse(Console.ReadLine());
            for (i = 1; i <= j; i++)
            {
                n = int.Parse(Console.ReadLine());
                if (n > 0)
                {
                    if (n % 2 == 0)
                    {
                        Console.WriteLine("EVEN POSITIVE");
                    }
                    else
                    {
                        Console.WriteLine("ODD POSITIVE");
                    }
                }
                else if (n == 0)
                {
                    Console.WriteLine("NULL");
                }
                else if (n < 0)
                {
                    if (n % 2 == 0)
                    {
                        Console.WriteLine("EVEN NEGATIVE");
                    }
                    else
                    {
                        Console.WriteLine("ODD NEGATIVE");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
