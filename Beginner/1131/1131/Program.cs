using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1131
{
    class Program
    {
        static void Main(string[] args)
        {
            int Inter = 0;
            int Gremio = 0;
            int Empates = 0;
            Start:
            while (true)
            {
                string[] toklens = Console.ReadLine().Split(' ');
                int a = Convert.ToInt32(toklens[0]);
                int b = Convert.ToInt32(toklens[1]);

                if (a > b)
                {
                    Inter++;
                }
                else if (b > a)
                {
                    Gremio++;
                }
                else
                {
                    Empates++;
                }

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                int x = Convert.ToInt32(Console.ReadLine());

                if (x == 1)
                {
                    goto Start;
                }
                else if(x==2)
                {
                    break;
                }

            }
            int result = Inter + Gremio + Empates;

            Console.WriteLine("{0} grenais",result);
            Console.WriteLine("Inter:{0}",Inter);
            Console.WriteLine("Gremio:{0}", Gremio);
            Console.WriteLine("Empates:{0}", Empates);
            if (Inter > Gremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else if (Inter == Gremio)
            {
                Console.WriteLine("Não houve vencedor");
            }
            else
            {
                Console.WriteLine("Gremio venceu mais");
            }
        }
    }
}
