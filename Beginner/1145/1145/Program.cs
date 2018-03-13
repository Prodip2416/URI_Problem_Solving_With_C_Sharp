using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y, a, b = 0;
            string[] tokens = Console.ReadLine().Split(' ');
             X = Convert.ToInt32(tokens[0]);
             Y = Convert.ToInt32(tokens[1]);
            if (X < Y && X > 1 && X < 20)
            {
                for (a = 1; a <= Y; a++)
                {
                    b++;
                    if (b == X) Console.WriteLine(a);

                    else Console.Write(a + " ");

                    if (b == X)
                    {
                        b = 0;
                        Console.WriteLine();
                    }
                   
                }
            }
        }
    }
}
