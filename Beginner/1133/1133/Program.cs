using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1133
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if (b > a)
            {
                for (int i = a+1; i < b; i++)
                {
                    if (i%5 == 2 || i%5==3)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else if (a > b)
            {
                for (int i = b+1; i < a; i++)
                {
                    if (i % 5 == 2 || i % 5 == 3)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
