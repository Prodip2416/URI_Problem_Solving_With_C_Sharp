using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1146
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int X = Convert.ToInt32(Console.ReadLine());

                if (X == 0)
                {
                    break;
                }
                else
                {
                    for (int i = 1; i <= X; i++)
                    {
                        if (i == X)
                        {
                            Console.WriteLine(i);
                            break;
                        }
                        Console.Write(i+" ");
                    }
                }
            }
        }
    }
}
