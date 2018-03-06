using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1113
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] token = Console.ReadLine().Split(' ');

                int X = Convert.ToInt32(token[0]);
                int Y = Convert.ToInt32(token[1]);

                if (X == Y)
                {
                    break;
                }
                else
                {
                    if (X > Y)
                    {
                        Console.WriteLine("Decrescente");
                    }
                    else
                    {
                        Console.WriteLine("Crescente");
                    }
                }
            }
           

        }
    }
}
