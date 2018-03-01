using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1071
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int  i, s = 0;
            
            if (x < y)
            {
                for (i = x + 1; i < y; i++)
                {
                    if (i % 2 != 0) s += i;
                }
            }
            else
            {
                for (i = y + 1; i < x; i++)
                {
                    if (i % 2 != 0) s += i;
                }
            }
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
