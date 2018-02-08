using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1047
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split();

            int hi = int.Parse(tokens[0]);
            int mi = int.Parse(tokens[1]);
            int hf = int.Parse(tokens[2]);
            int mf = int.Parse(tokens[3]);

            int hr, mr;

            hr = hf - hi;
            if (hr < 0)
                hr = 24 + hf - hi;
            mr = mf - mi;
            if (mr < 0)
            {
                mr = 60 + mf - mi;
                hr--;
            }

            if (hf == hi && mf == mi)
                Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
            else
                Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", hr, mr);

            Console.ReadLine();
        }
    }
}
