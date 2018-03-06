using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1115
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                int X = Convert.ToInt32(tokens[0]);
                int Y = Convert.ToInt32(tokens[1]);

                if (X == 0 || Y == 0)
                {
                    break;
                }
                else
                {
                    if (X > 0 && Y > 0)
                    {
                        Console.WriteLine("primeiro");
                    }
                    else if (X > 0 && Y < 0)
                    {
                        Console.WriteLine("quarto");
                    }
                    else if (X < 0 && Y < 0)
                    {
                        Console.WriteLine("terceiro");
                    }
                    else if (X < 0 && Y > 0)
                    {
                        Console.WriteLine("segundo");
                    }
                }
            }
        }
    }
}
