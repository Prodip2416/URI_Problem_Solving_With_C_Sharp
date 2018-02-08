using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1046
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split();

            int a = int.Parse(tokens[0]);
            int b = int.Parse(tokens[1]);

            int X=0;
            X = 24 - a;
            X = X + b;
            int Y;
            if (X > 24)
            {
                Console.WriteLine("O JOGO DUROU {0} HORA(S)", (X - 24));
            }
            else
            {
                Console.WriteLine("O JOGO DUROU {0} HORA(S)", X);
            }

            Console.ReadLine();
        }
    }
}
